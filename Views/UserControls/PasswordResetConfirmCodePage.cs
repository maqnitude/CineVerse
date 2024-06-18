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
        public PasswordResetConfirmCodePage(AuthenticationService authenticationService)
        {
            InitializeComponent();

            _authenticationService = authenticationService;

            inpGrpCode.Label = "Verification Code";
            inpGrpCode.PlaceholderText = "Enter the verification code";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _authenticationService.VerifyCode(inpGrpCode.InputText);
        }
    }
}
