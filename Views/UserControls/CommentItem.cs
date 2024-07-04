using CineVerse.Core.Events;
using CineVerse.Core.Interfaces;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Views.UserControls
{
    public partial class CommentItem : UserControlComponent
    {
        private MainForm _mainForm;
        private ICommentable _commentable;
        private CommentEditor? _editor = null;

        private bool _isUpvoted;
        private bool _isDownvoted;

        private int _upvotes;
        private int _downvotes;

        private int _indentWidth = 20;

        public CommentItem()
        {
            InitializeComponent();

            _isDownvoted = false;
            _isUpvoted = false;
        }

        public string? GetCommentId()
        {
            if (_commentable is Comment comment)
            {
                return comment.Id;
            }
            return null;
        }
        
        public void DisposeCommentEditor()
        {
            _editor?.Dispose();
            _editor = null;
        }

        public async Task Initialize(MainForm mainForm, ICommentable commentable, IMediator mediator)
        {
            _mainForm = mainForm;
            SetCommentableData(commentable);
            SetMediator(mediator);

            var user = _mainForm.GetCurrentUser();
            await UpdateVoteButtons(commentable.Id, user.Id, _commentable.Upvotes, _commentable.Downvotes);

            RegisterEventHandlers();
        }

        private void SetCommentableData(ICommentable commentable)
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
                lblContent.Text = post.Content;
            }
            else if (_commentable is Comment comment)
            {
                lblTitle.Text = $"Replied by {comment.User.Username}";
                lblContent.Text = comment.Content;
                lblBy.Visible = false;
                lblUsername.Visible = false;
                lblCreatedAt.Dock = DockStyle.Left;
                pnlHeader.BackColor = Color.FromArgb(80, 80, 80);
            }
        }

        private void RegisterEventHandlers()
        {
            if (_commentable is Post post)
            {
                EventManager.Instance.Subscribe<PostVoteEventArgs>(EventType.PostVoteAdded, OnPostVoteAdded);
                EventManager.Instance.Subscribe<PostVoteEventArgs>(EventType.PostVoteChanged, OnPostVoteChanged);
                EventManager.Instance.Subscribe<PostVoteEventArgs>(EventType.PostVoteRemoved, OnPostVoteRemoved);
            }
            else if (_commentable is Comment comment)
            {
                EventManager.Instance.Subscribe<CommentVoteEventArgs>(EventType.CommentVoteAdded, OnCommentVoteAdded);
                EventManager.Instance.Subscribe<CommentVoteEventArgs>(EventType.CommentVoteChanged, OnCommentVoteChanged);
                EventManager.Instance.Subscribe<CommentVoteEventArgs>(EventType.CommentVoteRemoved, OnCommentVoteRemoved);
            }

            this.ControlRemoved += (s, e) => UnregisterEventHanders();
        }

        private void UnregisterEventHanders()
        {
            EventManager.Instance.Unsubscribe<PostVoteEventArgs>(EventType.PostVoteAdded, OnPostVoteAdded);
            EventManager.Instance.Unsubscribe<PostVoteEventArgs>(EventType.PostVoteChanged, OnPostVoteChanged);
            EventManager.Instance.Unsubscribe<PostVoteEventArgs>(EventType.PostVoteRemoved, OnPostVoteRemoved);

            EventManager.Instance.Unsubscribe<CommentVoteEventArgs>(EventType.CommentVoteAdded, OnCommentVoteAdded);
            EventManager.Instance.Unsubscribe<CommentVoteEventArgs>(EventType.CommentVoteChanged, OnCommentVoteChanged);
            EventManager.Instance.Unsubscribe<CommentVoteEventArgs>(EventType.CommentVoteRemoved, OnCommentVoteRemoved);
        }

        private async Task UpdateVoteButtons(string commentableId, string userId, int upvotes, int downvotes)
        {
            PostVote? postVote = null;
            CommentVote? commentVote = null;

            if (_commentable is Post post)
            {
                postVote = await PostService.Instance.GetPostVoteAsync(commentableId, userId);
            }
            else if (_commentable is Comment comment)
            {
                commentVote = await CommentService.Instance.GetCommentVoteAsync(commentableId, userId);
            }

            if (postVote != null)
            {
                _isUpvoted = postVote.IsUpvote;
                _isDownvoted = !postVote.IsUpvote;
            }
            else if (commentVote != null)
            {
                _isUpvoted = commentVote.IsUpvote;
                _isDownvoted = !commentVote.IsUpvote;
            }
            else
            {
                _isUpvoted = false;
                _isDownvoted = false;
            }

            if (_commentable.Id == commentableId)
            {
                _upvotes = upvotes;
                _downvotes = downvotes;

                btnUpvote.Text = _upvotes.ToString();
                btnDownvote.Text = _downvotes.ToString();
            }

            if (_isUpvoted)
            {
                btnUpvote.Image?.Dispose();
                btnUpvote.Image = Properties.Resources.upvote_fill_green;

                btnDownvote.Image?.Dispose();
                btnDownvote.Image = Properties.Resources.downvote;
            }
            else if (_isDownvoted)
            {
                btnUpvote.Image?.Dispose();
                btnUpvote.Image = Properties.Resources.upvote;

                btnDownvote.Image?.Dispose();
                btnDownvote.Image = Properties.Resources.downvote_fill_red;
            }
            else
            {
                btnUpvote.Image?.Dispose();
                btnUpvote.Image = Properties.Resources.upvote;

                btnDownvote.Image?.Dispose();
                btnDownvote.Image = Properties.Resources.downvote;
            }
        }

        private void ClearReplies()
        {
            foreach (var control in this.Controls.OfType<CommentItem>().ToList())
            {
                this.Controls.Remove(control);
            }
        }

        public async Task AddReply(Comment reply)
        {
            CommentItem replyItem = new CommentItem()
            {
                Padding = new Padding(left: _indentWidth, right: 0, top: 0, bottom: 0),
                Dock = DockStyle.Top,
            };
            await replyItem.Initialize(_mainForm, reply, _mediator);

            this.Controls.Add(replyItem);
            replyItem.BringToFront();

            // Recursively add replies
            await replyItem.LoadReplies();
        }

        public async Task LoadReplies()
        {
            this.SuspendLayout();

            ClearReplies();

            List<Comment>? replies = null;

            if (_commentable is Post post)
            {
                replies = await PostService.Instance.GetPostRepliesAsync(post.Id);
            }
            else if (_commentable is Comment comment)
            {
                replies = await CommentService.Instance.GetCommentRepliesAsync(comment.Id);
            }

            if (replies != null)
            {
                foreach (Comment reply in replies)
                {
                    await AddReply(reply);
                }
            }

            this.ResumeLayout();
        }

        //private void ToggleButton(bool toggleOn, Button button, Image imageOn, Image imageOff, Color colorOn, Color colorOff)
        //{
        //    button.Image = toggleOn ? imageOn : imageOff;
        //    button.ForeColor = toggleOn ? colorOn : colorOff;
        //}

        private void HoverButton(bool isToggled, Button button, Image hoverImage, Image defaultImage, Color hoverColor, Color defaultColor)
        {
            button.Image = isToggled ? hoverImage : defaultImage;
            button.ForeColor = isToggled ? hoverColor : defaultColor;
        }

        //private void UpvoteButtonAction()
        //{
        //    _isUpvoted = !_isUpvoted;
        //    ToggleButton(_isUpvoted, btnUpvote, Properties.Resources.upvote_fill_green, Properties.Resources.upvote, Color.FromArgb(0, 138, 22), Color.FromArgb(170, 170, 170));
        //    if (_isUpvoted)
        //    {
        //        _isDownvoted = false;
        //        ToggleButton(_isDownvoted, btnDownvote, Properties.Resources.downvote_fill_red, Properties.Resources.downvote, Color.FromArgb(197, 7, 4), Color.FromArgb(170, 170, 170));
        //    }
        //}

        //private void DownVoteButtonAction()
        //{
        //    _isDownvoted = !_isDownvoted;
        //    ToggleButton(_isDownvoted, btnDownvote, Properties.Resources.downvote_fill_red, Properties.Resources.downvote, Color.FromArgb(197, 7, 4), Color.FromArgb(170, 170, 170));
        //    if (_isDownvoted)
        //    {
        //        _isUpvoted = false;
        //        ToggleButton(_isUpvoted, btnUpvote, Properties.Resources.upvote_fill_green, Properties.Resources.upvote, Color.FromArgb(0, 138, 22), Color.FromArgb(170, 170, 170));
        //    }
        //}

        // This needs refactoring, i.e., shared event args VoteEventArgs or something
        private async void OnPostVoteAdded(object sender, PostVoteEventArgs e)
        {
            if (_commentable is Post post && post.Id == e.PostId)
            {
                await UpdateVoteButtons(e.PostId, e.UserId, e.Upvotes, e.Downvotes);
            }
        }

        private async void OnPostVoteChanged(object sender, PostVoteEventArgs e)
        {
            if (_commentable is Post post && post.Id == e.PostId)
            {
                await UpdateVoteButtons(e.PostId, e.UserId, e.Upvotes, e.Downvotes);
            }
        }

        private async void OnPostVoteRemoved(object sender, PostVoteEventArgs e)
        {
            if (_commentable is Post post && post.Id == e.PostId)
            {
                await UpdateVoteButtons(e.PostId, e.UserId, e.Upvotes, e.Downvotes);
            }
        }

        private async void OnCommentVoteAdded(object sender, CommentVoteEventArgs e)
        {
            if (_commentable is Comment comment && comment.Id == e.CommentId)
            {
                await UpdateVoteButtons(e.CommentId, e.UserId, e.Upvotes, e.Downvotes);
            }
        }

        private async void OnCommentVoteChanged(object sender, CommentVoteEventArgs e)
        {
            if (_commentable is Comment comment && comment.Id == e.CommentId)
            {
                await UpdateVoteButtons(e.CommentId, e.UserId, e.Upvotes, e.Downvotes);
            }
        }

        private async void OnCommentVoteRemoved(object sender, CommentVoteEventArgs e)
        {
            if (_commentable is Comment comment && comment.Id == e.CommentId)
            {
                await UpdateVoteButtons(e.CommentId, e.UserId, e.Upvotes, e.Downvotes);
            }
        }

        private async void btnUpvote_Click(object sender, EventArgs e)
        {
            var user = _mainForm.GetCurrentUser();

            if (_isUpvoted)
            {
                if (_commentable is Post post)
                {
                    await PostService.Instance.RemovePostVoteAsync(post.Id, user.Id);
                }
                else if (_commentable is Comment comment)
                {
                    await CommentService.Instance.RemoveCommentVoteAsync(comment.Id, user.Id);
                }
            }
            else
            {
                if (_commentable is Post post)
                {
                    await PostService.Instance.AddOrUpdatePostVoteAsync(post.Id, user.Id, true);
                }
                else if (_commentable is Comment comment)
                {
                    await CommentService.Instance.AddOrUpdateCommentVoteAsync(comment.Id, user.Id, true);
                }
            }
        }

        private async void btnDownvote_Click(object sender, EventArgs e)
        {
            var user = _mainForm.GetCurrentUser();

            if (_isDownvoted)
            {
                if (_commentable is Post post)
                {
                    await PostService.Instance.RemovePostVoteAsync(post.Id, user.Id);
                }
                else if (_commentable is Comment comment)
                {
                    await CommentService.Instance.RemoveCommentVoteAsync(comment.Id, user.Id);
                }
            }
            else
            {
                if (_commentable is Post post)
                {
                    await PostService.Instance.AddOrUpdatePostVoteAsync(post.Id, user.Id, false);
                }
                else if (_commentable is Comment comment)
                {
                    await CommentService.Instance.AddOrUpdateCommentVoteAsync(comment.Id, user.Id, false);
                }
            }
        }

        private void btnUpvote_MouseEnter(object sender, EventArgs e)
        {
            //HoverButton(!_isUpvoted, btnUpvote, Properties.Resources.upvote_fill_green, Properties.Resources.upvote, Color.FromArgb(0, 138, 22), Color.FromArgb(170, 170, 170));
        }
        private void btnUpvote_MouseLeave(object sender, EventArgs e)
        {
            //HoverButton(_isUpvoted, btnUpvote, Properties.Resources.upvote_fill_green, Properties.Resources.upvote, Color.FromArgb(0, 138, 22), Color.FromArgb(170, 170, 170));
        }
        private void btnDownvote_MouseEnter(object sender, EventArgs e)
        {
            //HoverButton(!_isDownvoted, btnDownvote, Properties.Resources.downvote_fill_red, Properties.Resources.downvote, Color.FromArgb(179, 7, 4), Color.FromArgb(170, 170, 170));
        }
        private void btnDownvote_MouseLeave(object sender, EventArgs e)
        {
            //HoverButton(_isDownvoted, btnDownvote, Properties.Resources.downvote_fill_red, Properties.Resources.downvote, Color.FromArgb(179, 7, 4), Color.FromArgb(170, 170, 170));
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            if (_editor == null || _editor.IsDisposed)
            {
                _editor = new CommentEditor(_commentable)
                {
                    Padding = new Padding(left: _indentWidth, top: 0, right: 0, bottom: 0),
                    Dock = DockStyle.Top,
                };

                this.SuspendLayout();

                this.Controls.Add(_editor);

                int bodyIndex = this.Controls.GetChildIndex(pnlBody);
                this.Controls.SetChildIndex(_editor, bodyIndex); // put editor directly below the body

                this.ResumeLayout();

                _mediator?.Notify(this, "ReplyButtonClicked");
            }
            else if (_editor.Visible)
            {
                _editor.Hide();
            }
            else
            {
                _editor.Show();
            }
        }

        private void btnReply_MouseEnter(object sender, EventArgs e) => HoverButton(true, btnReply, Properties.Resources.quote_blue, Properties.Resources.quote, Color.FromArgb(51, 145, 255), Color.FromArgb(170, 170, 170));
        private void btnReply_MouseLeave(object sender, EventArgs e) => HoverButton(false, btnReply, Properties.Resources.quote_blue, Properties.Resources.quote, Color.FromArgb(51, 145, 255), Color.FromArgb(170, 170, 170));
    }
}
