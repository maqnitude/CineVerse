using CineVerse.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Views.UserControls
{
    public partial class SignUpPage : UserControlComponent
    {
        public SignUpPage()
        {
            InitializeComponent();

            inpGrpEmail.Label = "Email address";
            inpGrpEmail.PlaceholderText = "Enter your email address";
            inpGrpUsername.Label = "Username";
            inpGrpUsername.PlaceholderText = "Enter your username";
            inpGrpPassword.Label = "Password";
            inpGrpPassword.PlaceholderText = "Enter your password";
            inpGrpPassword.PasswordChar = '\u2022';
        }

        private void ClearInputs()
        {
            inpGrpEmail.InputText = "";
            inpGrpUsername.InputText = "";
            inpGrpPassword.InputText = "";
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = inpGrpEmail.InputText;
            string username = inpGrpUsername.InputText;
            string password = inpGrpPassword.InputText;

            bool status = await AuthService.Instance.SignUpAsync(email, username, password);
            if (status)
            {
                ClearInputs();
            }
        }
    }
}
