using CineVerse.Core.Events;
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
    public partial class UserListItem : UserControl
    {
        private User _currentUser;
        private User _user;
        private bool _showStatsPanel = true;
        public bool ShowStatsPanel
        {
            get => _showStatsPanel;
            set
            {
                _showStatsPanel = value;
                pnStats.Visible = value;
            }
        }

        public UserListItem(User user)
        {
            InitializeComponent();
            SetUser(user);
            SetupEvents();
            RegisterEventHandlers();
        }

        private void RegisterEventHandlers()
        {
            EventManager.Instance.Subscribe<FollowEventArgs>(EventType.UserFollowed, OnUserFollowed);
            EventManager.Instance.Subscribe<FollowEventArgs>(EventType.UserUnfollowed, OnUserUnfollowed);
        }

        private void SetUser(User user)
        {
            _user = user;

            lblUsername.Text = _user.Username;
            picUser.Image?.Dispose();
            picUser.Image = (_user.AvatarPath != null) ? new Bitmap(_user.AvatarPath) : Properties.Resources.default_avatar_transparent;
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public async void SetCurrentUser(User currentUser)
        {
            _currentUser = currentUser;
            bool isFollowing = await UserService.Instance.IsFollowingAsync(_currentUser.Id, _user.Id);
            UpdateFollowButtonIcon(isFollowing);
        }

        private void SetupEvents()
        {
            this.Click += UserListItem_Click;
            foreach (Control control in this.Controls)
            {
                if (control != null && control.Parent != pnStats && control != btnFollow)
                {
                    control.Click += UserListItem_Click;
                }
            }
        }

        private void UserListItem_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainForm;
            var navService = mainForm.GetNavService();
            ProfileScreen profileScreen = new ProfileScreen();
            var currentUser = mainForm.GetCurrentUser();
            navService.NavigateToScreen(profileScreen);
            profileScreen.SetProfileUser(_user);
            profileScreen.SetCurrentUser(currentUser);
        }

        private void UpdateFollowButtonIcon(bool isFollowing)
        {
            if (isFollowing)
            {
                btnFollow.Image = Properties.Resources.tick_green;
            }
            else
            {
                btnFollow.Image = Properties.Resources.add_follow;
            }
        }

        private void OnUserFollowed(object? sender, FollowEventArgs e)
        {
            if (_user.Id == e.FolloweeId)
            {
                UpdateFollowButtonIcon(true);
            }
        }

        private void OnUserUnfollowed(object? sender, FollowEventArgs e)
        {
            if (_user.Id == e.FolloweeId)
            {
                UpdateFollowButtonIcon(false);
            }
        }

        private async void btnFollow_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainForm;
            var currentUser = mainForm.GetCurrentUser();
            bool isFollowing = await UserService.Instance.IsFollowingAsync(currentUser.Id, _user.Id);
            if (isFollowing)
            {
                await UserService.Instance.UnfollowUserAsync(currentUser.Id, _user.Id);
            }
            else
            {
                await UserService.Instance.FollowUserAsync(currentUser.Id, _user.Id);
            }
        }
    }
}
