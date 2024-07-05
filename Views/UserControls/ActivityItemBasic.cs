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
    public partial class ActivityItemBasic : UserControl
    {
        private Comment _comment;
        public ActivityItemBasic(Comment comment)
        {
            InitializeComponent();
            SetData(comment);
        }

        public void SetData(Comment comment)
        {
            _comment = comment;
            picUser.Image?.Dispose();
            picUser.Image = (_comment.User.AvatarPath != null) ? new Bitmap(_comment.User.AvatarPath) : Properties.Resources.default_avatar_transparent;
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            lblUsername.Text = _comment.User.Username;
            lblContext1.Text = "commented on";
            lblTarget1.Text = _comment.Post.Title;
            lblContext2.Text = "";
            lblTarget2.Text = "";
            lblQuote.Text = _comment.Content;
        }
    }
}
