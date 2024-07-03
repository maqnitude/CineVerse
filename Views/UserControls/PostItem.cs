using CineVerse.Data.Entities;
using CineVerse.Forms;
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

        private bool _isUpvoted;
        private bool _isDownvoted;

        public PostItem()
        {
            InitializeComponent();
            _isUpvoted = false;
            _isDownvoted = false;

            RegisterEventHandlers();
        }

        public void Initialize(MainForm mainForm, Post post)
        {
            _mainForm = mainForm;
            SetPostData(post);
        }

        public void SetPostData(Post post)
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
        }

        private async void OnClick(object sender, EventArgs e)
        {
            var navService = _mainForm.GetNavService();
            var postDetailsScreen = new PostDetailsScreen();
            await postDetailsScreen.Initialize(_mainForm, _post);

            navService.NavigateToScreen(postDetailsScreen, false);
        }
    }
}
