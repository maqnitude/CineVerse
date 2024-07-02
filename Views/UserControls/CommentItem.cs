using CineVerse.Core.Interfaces;
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
        private ICommentable _commentable;
        private bool _isUpvoted;
        private bool _isDownvoted;

        public CommentItem()
        {
            InitializeComponent();
            _isDownvoted = false;
            _isUpvoted = false;
        }

        public void SetCommentableData(ICommentable commentable)
        {
            _commentable = commentable;

            picUser.Image?.Dispose();
            picUser.Image = (_commentable.User.AvatarPath != null) ? new Bitmap(_commentable.User.AvatarPath) : Properties.Resources.user_big;
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            lblCreatedAt.Text = _commentable.CreatedAt.ToString("'on' MMMM dd, yyyy 'at' HH:mm tt");

            if (_commentable is Post post)
            {
                lblTitle.Text = post.Title;
                lblUsername.Text = _commentable.User.Username;
            }
            else if (_commentable is Comment comment)
            {
                lblTitle.Text = $"Replied by {comment.User.Username}";
                lblBy.Visible = false;
                lblUsername.Visible = false;
                lblCreatedAt.Dock = DockStyle.Left;
                pnHeader.BackColor = Color.FromArgb(80, 80, 80);
            }

            // set _isDownvoted and _isUpvoted here
        }

        public void AddReply(Comment reply)
        {
            CommentItem replyItem = new CommentItem();
            replyItem.SetCommentableData(reply);
            replyItem.Padding = new Padding(left: 10, right: 0, top: 0, bottom: 0);
            this.Controls.Add(replyItem);
            replyItem.BringToFront();
            replyItem.Dock = DockStyle.Top;
        }

        private void ToggleButton(bool toggleOn, Button button, Image imageOn, Image imageOff, Color colorOn, Color colorOff)
        {
            button.Image = toggleOn ? imageOn : imageOff;
            button.ForeColor = toggleOn ? colorOn : colorOff;
        }

        private void HoverButton(bool isToggled, Button button, Image hoverImage, Image defaultImage, Color hoverColor, Color defaultColor)
        {
            button.Image = isToggled ? hoverImage : defaultImage;
            button.ForeColor = isToggled ? hoverColor : defaultColor;
        }

        private void UpvoteButtonAction()
        {
            _isUpvoted = !_isUpvoted;
            ToggleButton(_isUpvoted, btnUpvote, Properties.Resources.upvote_fill_green, Properties.Resources.upvote, Color.FromArgb(0, 138, 22), Color.FromArgb(170, 170, 170));
            if (_isUpvoted)
            {
                _isDownvoted = false;
                ToggleButton(_isDownvoted, btnDownvote, Properties.Resources.downvote_fill_red, Properties.Resources.downvote, Color.FromArgb(197, 7, 4), Color.FromArgb(170, 170, 170));
            }
        }

        private void DownVoteButtonAction()
        {
            _isDownvoted = !_isDownvoted;
            ToggleButton(_isDownvoted, btnDownvote, Properties.Resources.downvote_fill_red, Properties.Resources.downvote, Color.FromArgb(197, 7, 4), Color.FromArgb(170, 170, 170));
            if (_isDownvoted)
            {
                _isUpvoted = false;
                ToggleButton(_isUpvoted, btnUpvote, Properties.Resources.upvote_fill_green, Properties.Resources.upvote, Color.FromArgb(0, 138, 22), Color.FromArgb(170, 170, 170));
            }
        }

        private void btnUpvote_Click(object sender, EventArgs e) => UpvoteButtonAction();
        private void btnDownvote_Click(object sender, EventArgs e) => DownVoteButtonAction();
        private void btnUpvote_MouseEnter(object sender, EventArgs e) => HoverButton(!_isUpvoted, btnUpvote, Properties.Resources.upvote_fill_green, Properties.Resources.upvote, Color.FromArgb(0, 138, 22), Color.FromArgb(170, 170, 170));
        private void btnUpvote_MouseLeave(object sender, EventArgs e) => HoverButton(_isUpvoted, btnUpvote, Properties.Resources.upvote_fill_green, Properties.Resources.upvote, Color.FromArgb(0, 138, 22), Color.FromArgb(170, 170, 170));
        private void btnDownvote_MouseEnter(object sender, EventArgs e) => HoverButton(!_isDownvoted, btnDownvote, Properties.Resources.downvote_fill_red, Properties.Resources.downvote, Color.FromArgb(179, 7, 4), Color.FromArgb(170, 170, 170));
        private void btnDownvote_MouseLeave(object sender, EventArgs e) => HoverButton(_isDownvoted, btnDownvote, Properties.Resources.downvote_fill_red, Properties.Resources.downvote, Color.FromArgb(179, 7, 4), Color.FromArgb(170, 170, 170));


        private void btnReply_Click(object sender, EventArgs e)
        {
            // Navigate to new Comment form
        }
        private void btnReply_MouseEnter(object sender, EventArgs e) => HoverButton(true, btnReply, Properties.Resources.quote_blue, Properties.Resources.quote, Color.FromArgb(51, 145, 255), Color.FromArgb(170, 170, 170));
        private void btnReply_MouseLeave(object sender, EventArgs e) => HoverButton(false, btnReply, Properties.Resources.quote_blue, Properties.Resources.quote, Color.FromArgb(51, 145, 255), Color.FromArgb(170, 170, 170));
    }
}
