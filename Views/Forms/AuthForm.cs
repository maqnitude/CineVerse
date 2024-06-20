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
        private readonly NavigationService _navService;

        private SignInPage _signInPage;
        private SignUpPage _signUpPage;
        private PasswordResetPage _passwordResetPage;
        private PasswordResetSendCodePage _passwordResetSendCodePage;
        private PasswordResetConfirmCodePage _passwordResetConfirmCodePage;

        private bool _isUserSignedIn = false;

        public AuthForm()
        {
            InitializeComponent();

            AuthService.Instance.SetMediator(this);

            _navService = new NavigationService(this, pnPageContainer);

            this.StartPosition = FormStartPosition.CenterScreen;

            _signInPage = new SignInPage();
            _signUpPage = new SignUpPage();
            _passwordResetPage = new PasswordResetPage();
            _passwordResetSendCodePage = new PasswordResetSendCodePage();
            _passwordResetConfirmCodePage = new PasswordResetConfirmCodePage();

            _signInPage.SetMediator(this);
            _signUpPage.SetMediator(this);
            _passwordResetPage.SetMediator(this);
            _passwordResetSendCodePage.SetMediator(this);
            _passwordResetConfirmCodePage.SetMediator(this);

            _navService.RegisterScreen("signIn", _signInPage);
            _navService.RegisterScreen("signUp", _signUpPage);
            _navService.RegisterScreen("passwordReset", _passwordResetPage);
            _navService.RegisterScreen("sendCode", _passwordResetSendCodePage);
            _navService.RegisterScreen("confirmCode", _passwordResetConfirmCodePage);

            _navService.NavigateToScreen("signIn");

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
                    _navService.NavigateToScreen("signIn");
                    break;
                case "ShowSignUpPage":
                    _navService.NavigateToScreen("signUp");
                    break;
                case "ShowPasswordResetPage":
                    _navService.NavigateToScreen("passwordReset");
                    break;
                case "ShowPasswordResetSendCodePage":
                    _navService.NavigateToScreen("sendCode");
                    break;
                case "ShowPasswordResetConfirmCodePage":
                    _navService.NavigateToScreen("confirmCode");
                    break;
            }
        }

        private void RegisterEventHandlers()
        {
            EventManager.Instance.Subscribe<UserEventArgs>(EventType.UserSignedIn, OnUserSignedIn);
        }

        private void UnregisterEventHandlers()
        {
            EventManager.Instance.Unsubscribe<UserEventArgs>(EventType.UserSignedIn, OnUserSignedIn);
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
