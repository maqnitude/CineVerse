using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CineVerse.Data;
using CineVerse.Data.Entities;
using CineVerse.Core.Events;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Collections.Specialized;

namespace CineVerse.Core.Services
{
    public class AuthenticationService
    {
        private static AuthenticationService? _instance;
        private string _currentEmail { get; set; }
        private string _verificationCode {  get; set; }
        private DateTime _codeGenerationTime {  get; set; }

        private AuthenticationService() { }

        public static AuthenticationService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AuthenticationService();
                }
                return _instance;
            }
        }

        public Tuple<bool, string> IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return Tuple.Create(false, "Email cannot be empty.");
            }
            
            bool isValid = new EmailAddressAttribute().IsValid(email);
            if (!isValid)
            {
                return Tuple.Create(false, "Please enter a valid email.");
            }

            return Tuple.Create(true, "Email is valid.");
        }

        public Tuple<bool, string> IsUsernameValid (string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return Tuple.Create(false, "Username cannot be empty.");
            }
            
            if (username.Length <= 6 || username.Length >= 100)
            {
                return Tuple.Create(false, "Username must be between 6 and 100 characters long.");
            } 

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_\-]+$"))
            {
                return Tuple.Create(false, "Username can only contain alphanumeric characters, underscores and hyphens.");
            }

            if (username.StartsWith(" ") || username.EndsWith(" "))
            {
                return Tuple.Create(false, "Username cannot start or end with a space.");
            }

            return Tuple.Create(true, "Username is valid.");
        }

        public Tuple<bool, string> IsPasswordValid(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return Tuple.Create(false, "Password cannot be empty.");
            }
            
            if (password.Length < 8)
            {
                return Tuple.Create(false, "Password must be at least 8 characters long.");
            }

            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
            {
                return Tuple.Create(false, "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.");
            }

            return Tuple.Create(true, "Password is valid.");
        }

        public string HashPassword(string password)
        {
            using(var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public async Task<Tuple<bool, string>> SignInAsync(string username, string password)
        {
            Tuple<bool, string> usernameValidationResult = IsUsernameValid(username);
            if (!usernameValidationResult.Item1)
            {
                return usernameValidationResult;
            }

            Tuple<bool, string> passwordValidationResult = IsPasswordValid(password);
            if (!passwordValidationResult.Item1)
            {
                return passwordValidationResult;
            }

            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var user = await unitOfWork.Users.GetUserByUsernameAsync(username);
                if (user == null)
                {
                    return Tuple.Create(false, "User not found");
                }
                else if (user.Password == HashPassword(password))
                {
                    EventManager.Instance.Publish(EventType.UserLoggedIn, this, EventArgs.Empty);
                    return Tuple.Create(true, "Sign in successful!");
                }
                else
                {
                    return Tuple.Create(false, "Incorrect password.");
                }
            }
        }

        public async Task<Tuple<bool, string>> SignUpAsync(string email, string username, string password)
        {
            Tuple<bool, string> emailValidationResult = IsEmailValid(email);
            if (!emailValidationResult.Item1)
            {
                return emailValidationResult;
            }

            Tuple<bool, string> usernameValidationResult = IsUsernameValid(username);
            if (!usernameValidationResult.Item1)
            {
                return usernameValidationResult;
            }

            Tuple<bool, string> passwordValidationResult = IsPasswordValid(password);
            if (!passwordValidationResult.Item1)
            {
                return passwordValidationResult;
            }

            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var newUser = new User()
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = email,
                    Name = username,
                    Username = username,
                    Password = HashPassword(password),
                };
                await unitOfWork.Users.AddAsync(newUser);
                await unitOfWork.CompleteAsync();
            }
            return Tuple.Create(true, "Sign up successful!");
        }

        public void GenerateVerificationCode()
        {
            Random random = new Random();
            const int length = 6;
            _verificationCode = "";
            
            for (int i = 0; i < length; i++)
            {
                _verificationCode += random.Next(0, 9).ToString();
            }
            _codeGenerationTime = DateTime.Now;
        }

        public void SendVerificationCode(string receivedEmail)
        {
            Tuple<bool, string> emailValidationResult = IsEmailValid(receivedEmail);
            bool doesEmailExist = false;
            
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var user =  unitOfWork.Users.GetUserByEmailAsync(receivedEmail);
                if (user != null)
                {
                    doesEmailExist = true;
                }
            }
            
            if (doesEmailExist && emailValidationResult.Item1)
            {
                NameValueCollection emailSettings = (NameValueCollection)ConfigurationManager.GetSection("emailSettings");
                string email = emailSettings["Email"];
                string appPassword = emailSettings["AppPassword"];

                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new System.Net.Mail.MailAddress(email);
                    SmtpClient smtp = new SmtpClient();
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(mail.From.Address, appPassword);
                    smtp.Host = "smtp.gmail.com";
                    mail.To.Add(new MailAddress(receivedEmail));
                    mail.IsBodyHtml = true;
                    mail.Subject = "Password Reset Request";
                    mail.Body = $"<h2>Password Reset Request</h2>" +
                                $"<p>Hello,</p>" +
                                $"<p>We received a request to reset your password. Your verification code is:</p>" +
                                $"<h3>{_verificationCode}</h3>" +
                                $"<p>If you did not request a password reset, please ignore this email or contact support.</p>" +
                                $"<p>Thank you,</p>" +
                                $"<p>CineVerse</p>";

                    smtp.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to send verification email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool IsVerificationCodeValid(string inputCode)
        {
            TimeSpan timeSinceGeneration = DateTime.Now - _codeGenerationTime;
            
            if (inputCode == _verificationCode && timeSinceGeneration.TotalMinutes <= 5)
            {
                return true;
            }
            else
            {
                _verificationCode = "";
                return false;
            }
        }

        public async Task<bool> ResetPassword(string newPassword)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var user = await unitOfWork.Users.GetUserByEmailAsync(_currentEmail);
                if (user == null)
                {
                    return false;
                }
                else
                {
                    user.Password = HashPassword(newPassword);
                    return true;
                }
            }
        }
    }
}
