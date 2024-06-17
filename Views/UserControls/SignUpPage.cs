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
    public partial class SignUpPage : UserControl
    {
        public SignUpPage()
        {
            InitializeComponent();
            inputGroup1.Label = "Email address";
            inputGroup1.PlaceholderText = "Enter your email address";
            inputGroup2.Label = "Username";
            inputGroup2.PlaceholderText = "Enter your username";
            inputGroup3.Label = "Password";
            inputGroup3.PlaceholderText = "Enter your password";
            inputGroup3.PasswordChar = '\u2022';
        }
    }
}
