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
        private readonly AuthService _authenticationService;
        private readonly NavigationService _navigationService;

        public PasswordResetPage(AuthService authenticationService, NavigationService navigationService)
        {
            InitializeComponent();

            _authenticationService = authenticationService;
            _navigationService = navigationService;

            inpGrpNewPassword.Label = "New Password";
            inpGrpNewPassword.PlaceholderText = "Enter your new password";
            inpGrpNewPassword.PasswordChar = '\u2022';
            inpGrpConfirmNewPassword.Label = "Confirm New Password";
            inpGrpConfirmNewPassword.PlaceholderText = "Confirm your new password";
            inpGrpConfirmNewPassword.PasswordChar = '\u2022';
        }

        private void ClearInputs()
        {
            inpGrpNewPassword.InputText = "";
            inpGrpConfirmNewPassword.InputText = "";
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (inpGrpNewPassword.InputText != inpGrpConfirmNewPassword.InputText)
            {
                MessageBox.Show("Confirm password does not match!", "Error");
                return;
            }
            _authenticationService.ResetPassword(inpGrpNewPassword.InputText);
            ClearInputs();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
            _navigationService.NavigateToScreen("signIn");
        }
    }
}
