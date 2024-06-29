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
    public partial class ProfileScreen : UserControl
    {
        private User _user;

        public ProfileScreen()
        {
            InitializeComponent();
        }

        public void SetUserData(User user)
        {
            lblUsername.Text = user.Username;
            picAvatar.Image = (user.AvatarPath != null) ? new Bitmap(user.AvatarPath) : Properties.Resources.default_avatar;
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            _user = user;
        }
    }
}
