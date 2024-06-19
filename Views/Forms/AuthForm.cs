using CineVerse.Core.Events;
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
    public partial class AuthForm : Form, IMediator
    {
        private readonly EventManager _eventManager;
        private readonly AuthService _authenticationService;
        private readonly NavigationService _navigationService;

        private SignInPage _signInPage;
        private SignUpPage _signUpPage;
        private PasswordResetPage _passwordResetPage;
        private PasswordResetSendCodePage _passwordResetSendCodePage;
        private PasswordResetConfirmCodePage _passwordResetConfirmCodePage;

        private bool _isUserSignedIn = false;

        public AuthForm(EventManager eventManager, AuthService authenticationService)
        {
            InitializeComponent();

            _eventManager = eventManager;
            _authenticationService = authenticationService;
            _authenticationService.SetMediator(this);

            _navigationService = new NavigationService(this, pnPageContainer);

            this.StartPosition = FormStartPosition.CenterScreen;

            _signInPage = new SignInPage(_authenticationService);
            _signUpPage = new SignUpPage(_authenticationService);
            _passwordResetPage = new PasswordResetPage(_authenticationService, _navigationService);
            _passwordResetSendCodePage = new PasswordResetSendCodePage(_authenticationService, _navigationService);
            _passwordResetConfirmCodePage = new PasswordResetConfirmCodePage(_authenticationService, _navigationService);

            _signInPage.SetMediator(this);
            _signUpPage.SetMediator(this);
            _passwordResetPage.SetMediator(this);
            _passwordResetSendCodePage.SetMediator(this);
            _passwordResetConfirmCodePage.SetMediator(this);

            _navigationService.RegisterScreen("signIn", _signInPage);
            _navigationService.RegisterScreen("signUp", _signUpPage);
            _navigationService.RegisterScreen("passwordReset", _passwordResetPage);
            _navigationService.RegisterScreen("sendCode", _passwordResetSendCodePage);
            _navigationService.RegisterScreen("confirmCode", _passwordResetConfirmCodePage);

            _navigationService.NavigateToScreen("signIn");

            RegisterEventHandlers();
            btnSignIn.Click += btnSignIn_Click;
            btnSignUp.Click += btnSignUp_Click;
            this.FormClosed += OnFormClosed;
        }

        public void Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "ShowSignInPage":
                    _navigationService.NavigateToScreen("signIn");
                    break;
                case "ShowSignUpPage":
                    _navigationService.NavigateToScreen("signUp");
                    break;
                case "ShowPasswordResetPage":
                    _navigationService.NavigateToScreen("passwordReset");
                    break;
                case "ShowPasswordResetSendCodePage":
                    _navigationService.NavigateToScreen("sendCode");
                    break;
                case "ShowPasswordResetConfirmCodePage":
                    _navigationService.NavigateToScreen("confirmCode");
                    break;
            }
        }

        private void RegisterEventHandlers()
        {
            _eventManager.Subscribe<UserEventArgs>(EventType.UserSignedIn, OnUserSignedIn);
        }

        private void UnregisterEventHandlers()
        {
            _eventManager.Unsubscribe<UserEventArgs>(EventType.UserSignedIn, OnUserSignedIn);
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

        private void OnUserSignedIn(object sender, UserEventArgs e)
        {
            _isUserSignedIn = true;

            this.Close();
            this.Dispose();
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            UnregisterEventHandlers();

            if (!_isUserSignedIn)
            {
                Application.Exit();
            }
        }
    }
}
