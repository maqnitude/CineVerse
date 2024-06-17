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
    public partial class PasswordResetPage : UserControl
    {
        public PasswordResetPage()
        {
            InitializeComponent();
            inputGroup1.Label = "New Password";
            inputGroup1.PlaceholderText = "Enter your new password";
            inputGroup1.PasswordChar = '\u2022';
            inputGroup2.Label = "Confirm New Password";
            inputGroup2.PlaceholderText = "Confirm your new password";
            inputGroup2.PasswordChar = '\u2022';
        }
    }
}
