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
        public PasswordResetSendCodePage()
        {
            InitializeComponent();
            inpGrpEmail.Label = "Email address";
            inpGrpEmail.PlaceholderText = "Enter your email to receive verification code";
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            AuthenticationService.Instance.GenerateVerificationCode();
            AuthenticationService.Instance.SendVerificationCode(inpGrpEmail.InputText);
        }
    }
}
