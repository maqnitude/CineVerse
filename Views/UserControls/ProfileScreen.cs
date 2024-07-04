﻿using CineVerse.Core.Events;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
    public partial class ProfileScreen : UserControlComponent
    {
        private User? _currentUser;
        private User? _profileUser;

        public ProfileScreen()
        {
            InitializeComponent();
        }

        public void SetProfileUser(User profileUser)
        {
            // set profile user
            _profileUser = profileUser;
            lblUsername.Text = _profileUser.Username;
            picAvatar.Image = (_profileUser.AvatarPath != null) ? new Bitmap(_profileUser.AvatarPath) : Properties.Resources.default_avatar;
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            lblBio.Text = _profileUser.Bio;
            LoadFavouriteMovieCards();
            LoadRecentlyLikedMovieCards();
            LoadFolloweeAvatars();
        }

        public void SetCurrentUser(User currentUser)
        {
            _currentUser = currentUser;
            SetupButton();
        }

        private async void LoadFavouriteMovieCards()
        {
            ClearFavouriteMovieCards();
            
            List<Movie?> favouriteMovies = await UserService.Instance.GetFavouriteMovies(_profileUser);
            if (favouriteMovies.All(movie => movie == null))
            {
                Label message = new Label
                {
                    Text = $"{_profileUser.Username} hasn't set any favourite movies!!!",
                    ForeColor = Color.FromArgb(178, 172, 162),
                    BackColor = Color.Transparent,
                    Dock = DockStyle.Fill,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10),
                };
                pnFavouriteMovieCards.Controls.Add(message);
            }
            else
            {
                var mainForm = this.FindForm() as MainForm;
                for (int i = 0; i < 4; i++)
                {
                    var movie = favouriteMovies[i];
                    if (movie != null)
                    {
                        var movieCard = new MovieCard();
                        await movieCard.Initialize(mainForm, movie, _mediator);
                        movieCard.SetSize("medium");
                        pnFavouriteMovieCards.Controls.Add(movieCard);
                        movieCard.Dock = DockStyle.Left;
                        movieCard.BringToFront();
                    }
                }
            }
        }

        private async void ClearFavouriteMovieCards()
        {
            foreach (MovieCard movieCard in pnFavouriteMovieCards.Controls.OfType<MovieCard>().ToList())
            {
                pnFavouriteMovieCards.Controls.Remove(movieCard);
                movieCard.Dispose();
            }
        }

        private async void LoadFolloweeAvatars()
        {
            ClearFolloweeAvatars();
            List<User> followees = await UserService.Instance.GetFolloweesByIdAsync(_profileUser.Id);
            if (followees.Count == 0)
            {
                Label message = new Label
                {
                    Text = $"{_profileUser.Username} hasn't followed anyone!!!",
                    ForeColor = Color.FromArgb(178, 172, 162),
                    BackColor = Color.Transparent,
                    Dock = DockStyle.Fill,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10),
                };
                pnFollowingUserCards.Controls.Add(message);
            }
            else
            {
                foreach(User followee in followees)
                {
                    var userAvatar = new CircularUserAvatar(followee);
                    pnFollowingUserCards.Controls.Add(userAvatar);
                    userAvatar.Dock = DockStyle.Left;
                    userAvatar.BringToFront();
                }
            }
        }

        private async void ClearFolloweeAvatars()
        {
            foreach (CircularUserAvatar userAvatar in pnFollowingUserCards.Controls.OfType<CircularUserAvatar>().ToList())
            {
                pnFollowingUserCards.Controls.Remove(userAvatar);
                userAvatar.Dispose();
            }
        }

        private async void LoadRecentlyLikedMovieCards()
        {
            ClearRecentlyLikedMovieCards();

            List<Movie> recentlyLikedMovies = await ListService.Instance.GetMoviesFromListAsync(_profileUser.LikedList.Id);
            if (recentlyLikedMovies.All(movie => movie == null))
            {
                Label message = new Label
                {
                    Text = $"{_profileUser.Username} hasn't liked any movie yet!!!",
                    ForeColor = Color.FromArgb(178, 172, 162),
                    BackColor = Color.Transparent,
                    Dock = DockStyle.Fill,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10),
                };
                pnRecentlyLikedMovieCards.Controls.Add(message);
            }
            else
            {
                var mainForm = this.FindForm() as MainForm;
                for (int i = 0; i < 4; i++)
                {
                    var movie = recentlyLikedMovies[i];
                    if (movie != null)
                    {
                        var movieCard = new MovieCard();
                        await movieCard.Initialize(mainForm, movie, _mediator);
                        movieCard.SetSize("medium");
                        pnFavouriteMovieCards.Controls.Add(movieCard);
                        movieCard.Dock = DockStyle.Left;
                        movieCard.BringToFront();
                    }
                }
            }
        }

        private async void ClearRecentlyLikedMovieCards()
        {
            foreach (MovieCard movieCard in pnRecentlyLikedMovieCards.Controls.OfType<MovieCard>().ToList())
            {
                pnRecentlyLikedMovieCards.Controls.Remove(movieCard);
                movieCard.Dispose();
            }
        }


        private void RegisterEventHandlers()
        {
            EventManager.Instance.Subscribe<FollowEventArgs>(EventType.UserFollowed, OnUserFollowed);
            EventManager.Instance.Subscribe<FollowEventArgs>(EventType.UserUnfollowed, OnUserUnfollowed);
        }

        private async void SetupButton()
        {
            if (_currentUser != null && _profileUser != null)
            {
                if (_currentUser.Id == _profileUser.Id)
                {
                    SetupEditProfileButton();
                }
                else
                {
                    RegisterEventHandlers();
                    bool isFollowing = await UserService.Instance.IsFollowingAsync(_currentUser.Id, _profileUser.Id);
                    SetupFollowButton(isFollowing);
                }
            }
        }

        private void SetupEditProfileButton()
        {
            btnAction.BackColor = Color.FromArgb(68, 82, 95);
            btnAction.ForeColor = Color.FromArgb(184, 201, 215);
            btnAction.Text = "EDIT PROFILE";
            btnAction.Click += btnEditProfile_Click;
        }

        private void SetupFollowButton(bool isFollowing)
        {
            btnAction.Click -= btnEditProfile_Click;
            btnAction.Click -= btnFollowUnfollow_Click;
            btnAction.MouseEnter -= btnFollowing_MouseEnter;
            btnAction.MouseLeave -= btnFollowing_MouseLeave;

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

        private void OnUserFollowed(object? sender, FollowEventArgs e)
        {
            if (_currentUser != null && _profileUser != null && e.FollowerId == _currentUser.Id && e.FolloweeId == _profileUser.Id)
            {
                SetupFollowButton(true);
            }
        }

        private void OnUserUnfollowed(object? sender, FollowEventArgs e)
        {
            if (_currentUser != null && _profileUser != null && e.FollowerId == _currentUser.Id && e.FolloweeId == _profileUser.Id)
            {
                SetupFollowButton(false);
            }
        }
    }
}
