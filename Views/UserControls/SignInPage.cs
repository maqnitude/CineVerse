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
        public SignInPage()
        {
            InitializeComponent();

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

        private void ClearInputs()
        {
            inpGrpUsername.InputText = "";
            inpGrpPassword.InputText = "";
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = inpGrpUsername.InputText;
            string password = inpGrpPassword.InputText;

            bool status = await AuthService.Instance.SignInAsync(username, password);
            if (status)
            {
                ClearInputs();
            }
        }
    }
}
