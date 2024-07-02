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
    public partial class PostItem : UserControl
    {
        private bool _isUpvoted;
        private bool _isDownvoted;

        public PostItem()
        {
            InitializeComponent();
            _isUpvoted = false;
            _isDownvoted = false;
        }

        public void SetPostData(Post post)
        {
            picUser.Image?.Dispose();
            picUser.Image = (post.User.AvatarPath != null) ? new Bitmap(post.User.AvatarPath) : Properties.Resources.user_big;
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            lblTitle.Text = post.Title;
            lblUsername.Text = post.User.Username;
            lblCreatedAt.Text = post.CreatedAt.ToString("MMM dd, yyyy 'at' H:mm tt");
        }
    }
}
