using CineVerse.Data.Entities;
using CineVerse.Forms;
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
    public partial class CircularUserAvatar : UserControl
    {
        private User _user;

        public CircularUserAvatar(User user)
        {
            InitializeComponent();
            SetUser(user);
        }

        public void SetUser(User user)
        {
            _user = user;

            picAvatar.Image?.Dispose();
            picAvatar.Image = (user.AvatarPath != null) ? new Bitmap(user.AvatarPath) : Properties.Resources.default_avatar_transparent;
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void picAvatar_MouseEnter(object sender, EventArgs e)
        {
            lblUsername.Show();
        }

        private void picAvatar_MouseLeave(object sender, EventArgs e)
        {
            lblUsername.Hide();
        }
    }
}
