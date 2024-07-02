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
        private Post _post;

        public PostItem(Post post)
        {
            InitializeComponent();

            SetPostData(post);
        }

        private void SetPostData(Post post)
        {
            _post = post;

            lblTitle.Text = _post.Title;
            lblUsername.Text = _post.User.Username;
            lblCreatedAt.Text = _post.CreatedAt.ToString();

            picAvatar.Image?.Dispose();
            if (_post.User.AvatarPath != null)
            {
                picAvatar.Image = new Bitmap(_post.User.AvatarPath);
                picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
