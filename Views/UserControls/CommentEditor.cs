using CineVerse.Core.Events;
using CineVerse.Core.Interfaces;
using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Views.UserControls
{
    public partial class CommentEditor : UserControl
    {
        private ICommentable _commentable;

        public CommentEditor(ICommentable commentable)
        {
            InitializeComponent();

            _commentable = commentable;

            EventManager.Instance.Subscribe<EventArgs>(EventType.PostReplyAdded, OnPostReplyAdded);
            EventManager.Instance.Subscribe<EventArgs>(EventType.CommentReplyAdded, OnCommentReplyAdded);
        }

        private void OnPostReplyAdded(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void OnCommentReplyAdded(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbContent.Text))
            {
                MessageBox.Show("Content is empty");
                return;
            }

            if (_commentable is Post post)
            {
                EventManager.Instance.Publish(EventType.PostReplyAdding, this,
                    new PostReplyEventArgs(post.Id, rtbContent.Text));
            }
            else if (_commentable is Comment comment)
            {
                EventManager.Instance.Publish(EventType.CommentReplyAdding, this,
                    new CommentReplyEventArgs(comment.PostId, comment.Id, rtbContent.Text));
            }
        }
    }
}
