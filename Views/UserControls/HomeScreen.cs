using CineVerse.Data.Entities;
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
    public partial class HomeScreen : UserControl
    {
        private User _user;
        public HomeScreen()
        {
            InitializeComponent();
        }

        public void SetUser(User user)
        {
            _user = user;
            lblWelcomeMessage.Text = $"Welcome back, {_user.Username}. Let's see what your friends have been watching...";
        }
    }
}
