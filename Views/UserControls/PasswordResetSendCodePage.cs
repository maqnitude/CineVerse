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
    public partial class PasswordResetSendCodePage : UserControlComponent
    {
        private readonly AuthenticationService _authenticationService;
        private readonly NavigationService _navigationService;

        public PasswordResetSendCodePage(AuthenticationService authenticationService, NavigationService navigationService)
        {
            InitializeComponent();

            _authenticationService = authenticationService;
            _navigationService = navigationService;

            inpGrpEmail.Label = "Email address";
            inpGrpEmail.PlaceholderText = "Enter your email to receive verification code";
        }

        private void ClearInputs()
        {
            inpGrpEmail.InputText = "";
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            _authenticationService.SendVerificationCode(inpGrpEmail.InputText);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
            _navigationService.NavigateToScreen("signIn");
        }
    }
}
