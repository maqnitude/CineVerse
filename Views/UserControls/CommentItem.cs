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
    public partial class CommentItem : UserControl
    {
        private Comment _comment;
        private bool _isLiked;

        public CommentItem()
        {
            InitializeComponent();
            _isLiked = false;
        }

        public void SetCommentData(Comment comment)
        {
            _comment = comment;
            // set _isLike here
            // _isLiked = true; or _isLiked = false;
        }

        public void AddReply(Comment reply)
        {
            CommentItem replyItem = new CommentItem();
            replyItem.SetCommentData(reply);
            replyItem.Padding = new Padding(left: 20, right: 0, top: 0, bottom: 0);
            this.Controls.Add(replyItem);
            replyItem.BringToFront();
            replyItem.Dock = DockStyle.Top;
        }


        private void btnLike_Click(object sender, EventArgs e)
        {
            _isLiked = !_isLiked;
            btnLike.Image = _isLiked ? Properties.Resources.comment_like_blue : Properties.Resources.comment_like;
            btnLike.ForeColor = _isLiked ? Color.FromArgb(51, 145, 255) : Color.FromArgb(170, 170, 170);
        }

        private void btnLike_MouseEnter(object sender, EventArgs e)
        {
            if (!_isLiked)
            {
                btnLike.Image = Properties.Resources.comment_like_blue;
                btnLike.ForeColor = Color.FromArgb(51, 145, 255);
            }
        }

        private void btnLike_MouseLeave(object sender, EventArgs e)
        {
            if (!_isLiked)
            {
                btnLike.Image = Properties.Resources.comment_like;
                btnLike.ForeColor = Color.FromArgb(170, 170, 170);
            }
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            // Navigate to new Comment form
        }

        private void btnReply_MouseEnter(object sender, EventArgs e)
        {
            btnReply.Image = Properties.Resources.quote_blue;
            btnReply.ForeColor = Color.FromArgb(51, 145, 255);
        }

        private void btnReply_MouseLeave(object sender, EventArgs e)
        {
            btnReply.Image = Properties.Resources.quote;
            btnReply.ForeColor = Color.FromArgb(170, 170, 170);
        }

    }
}
