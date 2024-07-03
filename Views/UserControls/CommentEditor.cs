using CineVerse.Core.Events;
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
    public partial class CommentEditor : UserControl
    {
        private ICommentable _commentable;

        public CommentEditor(ICommentable commentable)
        {
            InitializeComponent();

            _commentable = commentable;
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

            if (_commentable is Post)
            {
                EventManager.Instance.Publish(EventType.PostReplyAdding, this,
                    new PostReplyEventArgs(rtbContent.Text));
            }
            else if (_commentable is Comment)
            {
                EventManager.Instance.Publish(EventType.CommentReplyAdding, this,
                    new CommentReplyEventArgs(_commentable.Id, rtbContent.Text));
            }
        }
    }
}
