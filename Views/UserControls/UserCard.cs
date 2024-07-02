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
    public partial class UserCard : UserControl
    {
        public UserCard()
        {
            InitializeComponent();
        }

        public void SetUserData(User user)
        {
            picUserAvatar.Image = (user.AvatarPath != null) ? new Bitmap(user.AvatarPath) : Properties.Resources.default_avatar_transparent;
            lblUsername.Text = user.Username;
        }
    }
}
