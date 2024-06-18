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
    public partial class PasswordResetPage : UserControlComponent
    {
        public PasswordResetPage()
        {
            InitializeComponent();
            inpGrpNewPassword.Label = "New Password";
            inpGrpNewPassword.PlaceholderText = "Enter your new password";
            inpGrpNewPassword.PasswordChar = '\u2022';
            inpGrpConfirmNewPassword.Label = "Confirm New Password";
            inpGrpConfirmNewPassword.PlaceholderText = "Confirm your new password";
            inpGrpConfirmNewPassword.PasswordChar = '\u2022';
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            AuthenticationService.Instance.ResetPassword(inpGrpNewPassword.InputText);
        }
    }
}
