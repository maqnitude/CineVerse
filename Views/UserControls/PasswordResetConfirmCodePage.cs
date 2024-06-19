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
    public partial class PasswordResetConfirmCodePage : UserControlComponent
    {
        private readonly AuthenticationService _authenticationService;
        private readonly NavigationService _navigationService;
        public PasswordResetConfirmCodePage(AuthenticationService authenticationService, NavigationService navigationService)
        {
            InitializeComponent();

            _authenticationService = authenticationService;
            _navigationService = navigationService;

            inpGrpCode.Label = "Verification Code";
            inpGrpCode.PlaceholderText = "Enter the verification code";
        }

        private void ClearInputs()
        {
            inpGrpCode.InputText = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _authenticationService.VerifyCode(inpGrpCode.InputText);
            ClearInputs();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
            _navigationService.NavigateToScreen("sendCode");
        }
    }
}
