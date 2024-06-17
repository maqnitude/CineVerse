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
            inputGroup1.Label = "Username";
            inputGroup1.PlaceholderText = "Enter your username";
            inputGroup2.Label = "Password";
            inputGroup2.PlaceholderText = "Enter your password";
            inputGroup2.PasswordChar = '\u2022';
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _mediator?.Notify(this, "ShowPasswordResetPage");
        }
    }
}
