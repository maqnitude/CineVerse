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
    public partial class InputGroup : UserControl
    {
        public InputGroup()
        {
            InitializeComponent();
        }

        public InputGroup(string label, string? placeholder)
        {
            lblField.Text = label;
            if (placeholder != null)
            {
                txtInput.PlaceholderText = placeholder;
            }
        }

        public string Label
        {
            get { return lblField.Text; }
            set { lblField.Text = value; }
        }

        public string PlaceholderText
        {
            get { return txtInput.PlaceholderText; }
            set { txtInput.PlaceholderText = value; }
        }

        public char PasswordChar
        {
            get { return txtInput.PasswordChar; }
            set { txtInput.PasswordChar = value; }
        }

        public string InputText
        {
            get { return txtInput.Text; }
            set { txtInput.Text = value; }
        }
    }
}
