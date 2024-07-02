using CineVerse.Core.Services;
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
    public partial class ProfileScreen : UserControl
    {
        private User? _currentUser;
        private User? _profileUser;

        public ProfileScreen(User profileUser)
        {
            InitializeComponent();
            SetUsersData(profileUser);
            SetupButton();
        }

        public void SetUsersData(User profileUser)
        {
            // get current user
            var mainForm = this.FindForm() as MainForm;
            if (mainForm != null)
            {
                _currentUser = mainForm.GetCurrentUser();
            }

            // set profile user
            _profileUser = profileUser;
            lblUsername.Text = _profileUser.Username;
            picAvatar.Image = (_profileUser.AvatarPath != null) ? new Bitmap(_profileUser.AvatarPath) : Properties.Resources.default_avatar;
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void SetupButton()
        {
            if (_currentUser != null && _profileUser != null)
            {
                if (_currentUser == _profileUser)
                {
                    btnAction.BackColor = Color.FromArgb(68, 82, 95);
                    btnAction.ForeColor = Color.FromArgb(184, 201, 215);
                    btnAction.Text = "EDIT PROFILE";
                    btnAction.Click += btnEditProfile_Click;
                }
                else
                {
                    bool isFollowing = await UserService.Instance.IsFollowingAsync(_currentUser.Id, _profileUser.Id);
                    if (isFollowing)
                    {
                        btnAction.BackColor = Color.FromArgb(13, 125, 31);
                        btnAction.ForeColor = Color.FromArgb(188, 210, 176);
                        btnAction.Text = "FOLLOWING";

                        btnAction.MouseEnter += btnFollowing_MouseEnter;
                        btnAction.MouseLeave += btnFollowing_MouseLeave;
                    }
                    else
                    {
                        btnAction.BackColor = Color.FromArgb(68, 82, 95);
                        btnAction.ForeColor = Color.FromArgb(184, 201, 215);
                        btnAction.Text = "FOLLOW";
                    }
                    btnAction.Click += btnFollowUnfollow_Click;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainForm;
            var navService = mainForm.GetNavService();
            navService.NavigateBack();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainForm;
            var navService = mainForm.GetNavService();
            SettingsScreen settingsScreen = new SettingsScreen(_currentUser);
            navService.NavigateToScreen(settingsScreen);
        }

        private async void btnFollowUnfollow_Click(object sender, EventArgs e)
        {
            bool isFollowing = await UserService.Instance.IsFollowingAsync(_currentUser.Id, _profileUser.Id);
            if (isFollowing)
            {
                await UserService.Instance.UnfollowUserAsync(_currentUser.Id, _profileUser.Id);
            }
            else
            {
                await UserService.Instance.FollowUserAsync(_currentUser.Id, _profileUser.Id);
            }
        }

        private void btnFollowing_MouseEnter(object sender, EventArgs e)
        {
            btnAction.BackColor = Color.FromArgb(167, 86, 13);
            btnAction.ForeColor = Color.FromArgb(201, 199, 197);
            btnAction.Text = "UNFOLLOW";
        }

        private void btnFollowing_MouseLeave(object sender, EventArgs e)
        {
            btnAction.BackColor = Color.FromArgb(13, 125, 31);
            btnAction.ForeColor = Color.FromArgb(188, 210, 176);
            btnAction.Text = "FOLLOWING";
        }
    }
}
