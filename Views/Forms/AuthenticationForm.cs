using CineVerse.Core.Interfaces;
using CineVerse.Core.Services;
using CineVerse.Data;
using CineVerse.Views;
using CineVerse.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Forms
{
    public partial class AuthenticationForm : Form, IMediator
    {
        private readonly AuthenticationService _authenticationService;
        private readonly NavigationService _navigationService;

        private SignInPage _signInPage;
        private SignUpPage _signUpPage;
        private PasswordResetPage _passwordResetPage;
        private PasswordResetSendCodePage _passwordResetSendCodePage;
        private PasswordResetConfirmCodePage _passwordResetConfirmCodePage;

        public AuthenticationForm(AuthenticationService authenticationService)
        {
            InitializeComponent();

            _authenticationService = authenticationService;
            _authenticationService.SetMediator(this);

            _navigationService = new NavigationService(this, pnPageContainer);

            this.StartPosition = FormStartPosition.CenterScreen;

            _signInPage = new SignInPage(_authenticationService);
            _signUpPage = new SignUpPage(_authenticationService);
            _passwordResetPage = new PasswordResetPage(_authenticationService);
            _passwordResetSendCodePage = new PasswordResetSendCodePage(_authenticationService);
            _passwordResetConfirmCodePage = new PasswordResetConfirmCodePage(_authenticationService);

            _signInPage.SetMediator(this);
            _signUpPage.SetMediator(this);
            _passwordResetPage.SetMediator(this);
            _passwordResetSendCodePage.SetMediator(this);
            _passwordResetConfirmCodePage.SetMediator(this);

            _navigationService.RegisterScreen("sign in", _signInPage);
            _navigationService.RegisterScreen("sign up", _signUpPage);
            _navigationService.RegisterScreen("password reset", _passwordResetPage);
            _navigationService.RegisterScreen("send code", _passwordResetSendCodePage);
            _navigationService.RegisterScreen("confirm code", _passwordResetConfirmCodePage);

            _navigationService.NavigateToScreen("sign in");

            btnSignIn.Click += btnSignIn_Click;
            btnSignUp.Click += btnSignUp_Click;
        }

        public void Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "ShowSignInPage":
                    _navigationService.NavigateToScreen("sign in");
                    break;
                case "ShowSignUpPage":
                    _navigationService.NavigateToScreen("sign up");
                    break;
                case "ShowPasswordResetPage":
                    _navigationService.NavigateToScreen("password reset");
                    break;
                case "ShowPasswordResetSendCodePage":
                    _navigationService.NavigateToScreen("send code");
                    break;
                case "ShowPasswordResetConfirmCodePage":
                    _navigationService.NavigateToScreen("confirm code");
                    break;
            }
        }

        private void ResetButtonColors()
        {
            foreach (Button btn in pnTabContainer.Controls)
            {
                btn.BackColor = Color.FromArgb(150, 150, 150);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnSignIn.BackColor = Color.FromArgb(0, 157, 26);
            Notify(this, "ShowSignInPage");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnSignUp.BackColor = Color.FromArgb(0, 157, 26);
            Notify(this, "ShowSignUpPage");
        }
    }
}
