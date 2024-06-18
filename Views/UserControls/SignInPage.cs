using CineVerse.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Views.UserControls
{
    public partial class SignInPage : UserControlComponent
    {
        private readonly AuthenticationService _authenticationService;

        public SignInPage(AuthenticationService authenticationService)
        {
            InitializeComponent();

            _authenticationService = authenticationService;

            inpGrpUsername.Label = "Username";
            inpGrpUsername.PlaceholderText = "Enter your username";
            inpGrpPassword.Label = "Password";
            inpGrpPassword.PlaceholderText = "Enter your password";
            inpGrpPassword.PasswordChar = '\u2022';
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _mediator?.Notify(this, "ShowPasswordResetSendCodePage");
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = inpGrpUsername.InputText;
            string password = inpGrpPassword.InputText;

            var signInResult = await _authenticationService.SignInAsync(username, password);
            MessageBox.Show(signInResult.Item2);
        }
    }
}
