using CineVerse.Core.Events;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Forms;
using CineVerse.Properties;
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
        private MainForm _mainForm;
        private Post _post;

        private int _upvotes;
        private int _downvotes;

        private bool _isUpvoted;
        private bool _isDownvoted;

        public PostItem()
        {
            InitializeComponent();

            _isUpvoted = false;
            _isDownvoted = false;

            RegisterEventHandlers();
        }

        public async Task Initialize(MainForm mainForm, Post post)
        {
            _mainForm = mainForm;
            SetPostData(post);

            var user = _mainForm.GetCurrentUser();
            await UpdateVoteButtons(post.Id, user.Id, _post.Upvotes, _post.Downvotes);

            await UpdateReplyCount();
        }

        private void SetPostData(Post post)
        {
            _post = post;

            picUser.Image?.Dispose();
            picUser.Image = (post.User.AvatarPath != null) ? new Bitmap(post.User.AvatarPath) : Properties.Resources.user_big;
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            lblTitle.Text = post.Title;
            lblUsername.Text = post.User.Username;
            lblCreatedAt.Text = post.CreatedAt.ToString("MMM dd, yyyy 'at' H:mm tt");
        }

        private void RegisterEventHandlers()
        {
            this.Click += OnClick;

            foreach (Control control in this.Controls)
            {
                control.Click += OnClick;
            }

            EventManager.Instance.Subscribe<EventArgs>(EventType.PostReplyAdded, OnPostReplyAdded);
            EventManager.Instance.Subscribe<EventArgs>(EventType.CommentReplyAdded, OnCommentReplyAdded);

            EventManager.Instance.Subscribe<PostVoteEventArgs>(EventType.PostVoteAdded, OnPostVoteAdded);
            EventManager.Instance.Subscribe<PostVoteEventArgs>(EventType.PostVoteChanged, OnPostVoteChanged);
            EventManager.Instance.Subscribe<PostVoteEventArgs>(EventType.PostVoteRemoved, OnPostVoteRemoved);

            this.ControlRemoved += (s, e) => UnregisterEventHandlers();
        }

        private void UnregisterEventHandlers()
        {
            EventManager.Instance.Unsubscribe<EventArgs>(EventType.PostReplyAdded, OnPostReplyAdded);
            EventManager.Instance.Unsubscribe<EventArgs>(EventType.CommentReplyAdded, OnCommentReplyAdded);

            EventManager.Instance.Unsubscribe<PostVoteEventArgs>(EventType.PostVoteAdded, OnPostVoteAdded);
            EventManager.Instance.Unsubscribe<PostVoteEventArgs>(EventType.PostVoteChanged, OnPostVoteChanged);
            EventManager.Instance.Unsubscribe<PostVoteEventArgs>(EventType.PostVoteRemoved, OnPostVoteRemoved);
        }

        private async Task UpdateVoteButtons(string postId, string userId, int upvotes, int downvotes)
        {
            var vote = await PostService.Instance.GetPostVoteAsync(postId, userId);
            if (vote != null)
            {
                _isUpvoted = vote.IsUpvote;
                _isDownvoted = !vote.IsUpvote;
            }
            else
            {
                _isUpvoted = false;
                _isDownvoted = false;
            }

            if (_post.Id == postId)
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

        private async Task UpdateReplyCount()
        {
            int count = await PostService.Instance.CountPostRepliesAsync(_post.Id);
            
            btnComment.Text = count.ToString();
        }

        private async void OnClick(object sender, EventArgs e)
        {
            var navService = _mainForm.GetNavService();
            var postDetailsScreen = new PostDetailsScreen();
            await postDetailsScreen.Initialize(_mainForm, _post);

            navService.NavigateToScreen(postDetailsScreen, false);
        }

        private async void OnCommentReplyAdded(object sender, EventArgs e)
        {
            await UpdateReplyCount();
        }

        private async void OnPostReplyAdded(object sender, EventArgs e)
        {
            await UpdateReplyCount();
        }

        private async void OnPostVoteAdded(object sender, PostVoteEventArgs e)
        {
            if (_post.Id == e.PostId)
            {
                await UpdateVoteButtons(e.PostId, e.UserId, e.Upvotes, e.Downvotes);
                _post = await PostService.Instance.GetPostByIdAsync(e.PostId);
            }
        }

        private async void OnPostVoteChanged(object sender, PostVoteEventArgs e)
        {
            if (_post.Id == e.PostId)
            {
                await UpdateVoteButtons(e.PostId, e.UserId, e.Upvotes, e.Downvotes);
                _post = await PostService.Instance.GetPostByIdAsync(e.PostId);
            }
        }

        private async void OnPostVoteRemoved(object sender, PostVoteEventArgs e)
        {
            if (_post.Id == e.PostId)
            {
                await UpdateVoteButtons(e.PostId, e.UserId, e.Upvotes, e.Downvotes);
                _post = await PostService.Instance.GetPostByIdAsync(e.PostId);
            }
        }

        private async void btnUpvote_Click(object sender, EventArgs e)
        {
            var user = _mainForm.GetCurrentUser();

            if (_isUpvoted)
            {
                await PostService.Instance.RemovePostVoteAsync(_post.Id, user.Id);
            }
            else
            {
                await PostService.Instance.AddOrUpdatePostVoteAsync(_post.Id, user.Id, true);
            }
        }

        private async void btnDownvote_Click(object sender, EventArgs e)
        {
            var user = _mainForm.GetCurrentUser();

            if (_isDownvoted)
            {
                await PostService.Instance.RemovePostVoteAsync(_post.Id, user.Id);
            }
            else
            {
                await PostService.Instance.AddOrUpdatePostVoteAsync(_post.Id, user.Id, false);
            }
        }
    }
}
