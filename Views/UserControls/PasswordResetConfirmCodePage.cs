﻿using System;
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
        public PasswordResetConfirmCodePage()
        {
            InitializeComponent();
            inputGroup1.Label = "Verification Code";
            inputGroup1.PlaceholderText = "Enter the verification code";
        }
    }
}