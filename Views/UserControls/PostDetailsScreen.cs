using CineVerse.Core.Events;
using CineVerse.Core.Interfaces;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Views.UserControls
{
    public partial class PostDetailsScreen : UserControl, IMediator
    {
        private MainForm _mainForm;
        private Post _post;

        public PostDetailsScreen()
        {
            InitializeComponent();

            RegisterEventHandlers();
            this.Disposed += (s, e) => UnregisterEventHandlers();
        }

        public void Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "ReplyButtonClicked":
                    // Dispose the comment editor in every other comment item
                    if (sender is CommentItem s)
                    {
                        Action<CommentItem> DisposeEditor = null;
                        DisposeEditor = (c) =>
                        {
                            if (c != s)
                            {
                                c.DisposeCommentEditor();
                            }

                            foreach (Control control in c.Controls)
                            {
                                if (control is CommentItem commentItem)
                                {
                                    DisposeEditor(commentItem);
                                }
                            }
                        };

                        this.SuspendLayout();

                        if (s != rootCommentItem)
                        {
                            rootCommentItem.DisposeCommentEditor();
                        }

                        foreach (Control control in rootCommentItem.Controls)
                        {
                            if (control is CommentItem commentItem)
                            {
                                DisposeEditor(commentItem);
                            }
                        }

                        this.ResumeLayout();
                    }
                    break;
            }
        }

        private void RegisterEventHandlers()
        {
            UnregisterEventHandlers();

            EventManager.Instance.Subscribe<PostReplyEventArgs>(EventType.PostReplyAdding, OnPostReplyAdding);
            EventManager.Instance.Subscribe<EventArgs>(EventType.PostReplyAdded, OnPostReplyAdded);

            EventManager.Instance.Subscribe<CommentReplyEventArgs>(EventType.CommentReplyAdding, OnCommentReplyAdding);
            EventManager.Instance.Subscribe<EventArgs>(EventType.CommentReplyAdded, OnCommentReplyAdded);
        }

        private void UnregisterEventHandlers()
        {
            EventManager.Instance.Unsubscribe<PostReplyEventArgs>(EventType.PostReplyAdding, OnPostReplyAdding);
            EventManager.Instance.Unsubscribe<EventArgs>(EventType.PostReplyAdded, OnPostReplyAdded);

            EventManager.Instance.Unsubscribe<CommentReplyEventArgs>(EventType.CommentReplyAdding, OnCommentReplyAdding);
            EventManager.Instance.Unsubscribe<EventArgs>(EventType.CommentReplyAdded, OnCommentReplyAdded);
        }

        public async Task Initialize(MainForm mainForm, Post post)
        {
            _mainForm = mainForm;
            await SetPostData(post);
        }

        private async Task SetPostData(Post post)
        {
            _post = post;

            this.SuspendLayout();

            await rootCommentItem.Initialize(_mainForm, post, this);
            await rootCommentItem.LoadReplies();

            this.ResumeLayout();
        }

        private async void OnPostReplyAdding(object sender, PostReplyEventArgs e)
        {
            if (_post.Id == e.PostId)
            {
                var user = _mainForm.GetCurrentUser();
                await PostService.Instance.AddPostReplyAsync(_post.Id, user.Id, e.Content);

                EventManager.Instance.Publish(EventType.PostReplyAdded, this, EventArgs.Empty);
            }
        }

        private async void OnPostReplyAdded(object sender, EventArgs e)
        {
            this.SuspendLayout();

            await rootCommentItem.LoadReplies();

            this.ResumeLayout();
        }

        private async void OnCommentReplyAdding(object sender, CommentReplyEventArgs e)
        {
            if (_post.Id == e.PostId)
            {
                var user = _mainForm.GetCurrentUser();
                await CommentService.Instance.AddCommentReplyAsync(e.ParentCommentId, user.Id, e.Content);

                EventManager.Instance.Publish(EventType.CommentReplyAdded, this, EventArgs.Empty);
            }
        }

        private async void OnCommentReplyAdded(object sender, EventArgs e)
        {
            this.SuspendLayout();
            // TODO: load the replies of the parent comment instead
            await rootCommentItem.LoadReplies();

            this.ResumeLayout();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var navService = _mainForm.GetNavService();
            navService.NavigateBack();
        }
    }
}
