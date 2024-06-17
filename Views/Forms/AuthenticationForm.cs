using CineVerse.Core.Interfaces;
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
        private readonly UnitOfWork _unitOfWork;
        private SignInPage _signInPage;
        private SignUpPage _signUpPage;
        private PasswordResetPage _passwordResetPage;
        private PasswordResetSendCodePage _passwordResetSendCodePage;
        private PasswordResetConfirmCodePage _passwordResetConfirmCodePage;

        public AuthenticationForm()
        {
            InitializeComponent();
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

            _signInPage.Dock = DockStyle.Fill;
            _signUpPage.Dock = DockStyle.Fill;
            _passwordResetPage.Dock = DockStyle.Fill;
            _passwordResetSendCodePage.Dock = DockStyle.Fill;
            _passwordResetConfirmCodePage.Dock = DockStyle.Fill;

            ShowPage(_signInPage);

            pnPageContainer.Controls.Add(_signInPage);
            pnPageContainer.Controls.Add(_signUpPage);
            pnPageContainer.Controls.Add(_passwordResetPage);
            pnPageContainer.Controls.Add(_passwordResetSendCodePage);
            pnPageContainer.Controls.Add(_passwordResetConfirmCodePage);

            btnSignIn.Click += btnSignIn_Click;
            btnSignUp.Click += btnSignUp_Click;
        }

        public AuthenticationForm(UnitOfWork unitOfWork)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
        }

        public void Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "ShowSignInPage":
                    ShowPage(_signInPage);
                    break;
                case "ShowSignUpPage":
                    ShowPage(_signUpPage);
                    break;
                case "ShowPasswordResetPage":
                    ShowPage(_passwordResetPage);
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

        private void ShowPage(UserControl page)
        {
            _signInPage.Visible = false;
            _signUpPage.Visible = false;
            _passwordResetPage.Visible = false;
            _passwordResetSendCodePage.Visible = false;
            _passwordResetConfirmCodePage.Visible = false;
            page.Visible = true;
        }
    }
}
