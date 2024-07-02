using CineVerse.Core.Events;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Forms;
using CineVerse.Views.Forms;
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
    public partial class PostsScreen : UserControlComponent
    {
        private int _itemsPerPage = 24;
        private int _currentPage = 1;

        public int CurrentPage
        {
            get { return _currentPage; }
            set { _currentPage = value; }
        }

        public PostsScreen()
        {
            InitializeComponent();

            EventManager.Instance.Subscribe<EventArgs>(EventType.PostAdded, OnPostAdded);
        }

        private void ClearPostsContainer()
        {
            List<PostItem> postsToRemove = new List<PostItem>();

            foreach (Control control in pnlPostsContainer.Controls)
            {
                if (control is PostItem postItem)
                {
                    postsToRemove.Add(postItem);
                }
            }

            foreach (PostItem postItem in postsToRemove)
            {
                pnlPostsContainer.Controls.Remove(postItem);
            }
        }

        public async Task LoadPostsAsync()
        {
            pnlPostsContainer.SuspendLayout();

            ClearPostsContainer();

            List<Post> posts = await PostService.Instance.GetPostsAsync(_currentPage, _itemsPerPage);

            foreach (Post post in posts)
            {
                var postItem = new PostItem(post)
                {
                    Dock = DockStyle.Top,
                };
                pnlPostsContainer.Controls.Add(postItem);
            }

            pnlPostsContainer.ResumeLayout();
        }

        private async void OnPostAdded(object sender, EventArgs e)
        {
            _currentPage = 1;
            await LoadPostsAsync();
        }

        private void btnNewPost_Click(object sender, EventArgs e)
        {
            var newPostForm = new NewPostForm();
            newPostForm.ShowDialog();
        }
    }
}
