using CineVerse.Configuration;
using CineVerse.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineVerse.Data.Entities;
using CineVerse.Core.Services;
using CineVerse.Core.Events;
using CineVerse.Core.Interfaces;
using CineVerse.Views.UserControls;
using Accessibility;
using CineVerse.Views.Forms;

namespace CineVerse.Forms
{
    public partial class MainForm : Form, IMediator
    {
        private readonly NavigationService _navigationService;

        private readonly HomeScreen _homeScreen;
        private readonly MoviesScreen _moviesScreen;
        private readonly ListsScreen _listsScreen;
        private readonly PostsScreen _postsScreen;

        private Label _selectedTab;

        private User _currentUser;

        // TODO: Define the movie details screen, then just hide and unhide it
        // instead of creating a new one everytime
        public MainForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            _navigationService = new NavigationService(this, pnMain);

            _homeScreen = new HomeScreen();
            _moviesScreen = new MoviesScreen(_navigationService, 12);
            _listsScreen = new ListsScreen();
            _postsScreen = new PostsScreen();

            _moviesScreen.SetMediator(this);
            _listsScreen.SetMediator(this);
            _postsScreen.SetMediator(this);

            searchBar.SetMediator(this);

            _navigationService.RegisterScreen("homeScreen", _homeScreen);
            _navigationService.RegisterScreen("moviesScreen", _moviesScreen);
            _navigationService.RegisterScreen("listsScreen", _listsScreen);
            _navigationService.RegisterScreen("postsScreen", _postsScreen);

            RegisterEventHandlers();
        }

        public async void Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "OpenAddToListForm":
                    if (sender is MovieCard card)
                    {
                        var addToListForm = new AddToListForm(_currentUser, card.Movie);
                        await addToListForm.LoadListsAsync();
                        addToListForm.ShowDialog();
                    }
                    else if (sender is MovieDetailsScreen detailsScreen)
                    {
                        var addToListForm = new AddToListForm(_currentUser, detailsScreen.Movie);
                        await addToListForm.LoadListsAsync();
                        addToListForm.ShowDialog();
                    }

                    break;

                case "HideSearchResults":
                    searchBar.HideResults();
                    break;
            }
        }

        public User GetCurrentUser()
        {
            return _currentUser;
        }

        public NavigationService GetNavService()
        {
            return _navigationService;
        }

        private void RegisterEventHandlers()
        {
            EventManager.Instance.Subscribe<UserEventArgs>(EventType.UserSignedIn, OnUserSignedIn);

            EventManager.Instance.Subscribe<EventArgs>(EventType.UserSettingsChanged, OnUserSettingsChanged);

            EventManager.Instance.Subscribe<ListAddEventArgs>(EventType.ListAdding, OnListAdding);
            EventManager.Instance.Subscribe<ListMovieEventArgs>(EventType.ListMovieAdding, OnListMovieAdding);

            EventManager.Instance.Subscribe<ReviewEventArgs>(EventType.ReviewAdding, OnReviewAdding);

            EventManager.Instance.Subscribe<PostEventArgs>(EventType.PostAdding, OnPostAdding);

            // Click outside the search bar and the results list to hide the results list
            foreach (Control control in this.Controls)
            {
                if (control is SearchBar || control is SearchResultMovieItem) { return; }

                control.MouseUp += OnMouseUp;
            }

            // Add hover effects for nav items
            foreach (Control control in pnNavBar.Controls)
            {
                if (control is Label lbl)
                {
                    control.MouseEnter += OnNavItemMouseEnter;
                    control.MouseLeave += OnNavItemMouseLeave;
                }
            }
        }

        private void ResetNavItemColors()
        {
            foreach (Control control in pnNavBar.Controls)
            {
                if (control is Label lbl)
                {
                    lbl.ForeColor = Color.FromArgb(178, 172, 162);
                }
            }
        }

        private Image LoadImage(string imagePath)
        {
            Image image = null;
            if (imagePath != null)
            {
                try
                {
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        image = Image.FromStream(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    image = Properties.Resources.default_avatar;
                }
            }
            else
            {
                image = Properties.Resources.default_avatar;
            }
            return image;
        }

        private void UpdateUserDisplay()
        {
            btnUser.Text = _currentUser.Username;
            picUser.Image?.Dispose();
            picUser.Image = LoadImage(_currentUser.AvatarPath);
        }

        private void OnUserSignedIn(object sender, UserEventArgs e)
        {
            this.Show();

            _currentUser = e.User;

            UpdateUserDisplay();
            _homeScreen.SetUser(_currentUser);
            _listsScreen.SetUser(_currentUser);
            lblHomeTab_Click(this, EventArgs.Empty);
        }

        private void OnUserSettingsChanged(object? sender, EventArgs e)
        {
            UpdateUserDisplay();
        }

        private async void OnListAdding(object sender, ListAddEventArgs e)
        {
            await ListService.Instance.AddListAsync(_currentUser.Id, e.Name, e.Type, e.Description);

            EventManager.Instance.Publish(EventType.ListAdded, this, EventArgs.Empty);
        }

        private async void OnListMovieAdding(object sender, ListMovieEventArgs e)
        {
            //MessageBox.Show($"Adding movie with id({e.MovieId}) to {e.ListIds.Count} lists");
            await ListService.Instance.AddMovieToListsAsync(e.ListIds, e.MovieId);

            //EventManager.Instance.Publish(EventType.ListMovieAdded, this, EventArgs.Empty);
        }

        private async void OnReviewAdding(object sender, ReviewEventArgs e)
        {
            await MovieService.Instance.AddMovieReviewAsync(_currentUser.Id, e.MovieId, e.Rating, e.Content);

            EventManager.Instance.Publish(EventType.ReviewAdded, this, EventArgs.Empty);
        }

        private async void OnPostAdding(object sender, PostEventArgs e)
        {
            await PostService.Instance.AddPostAsync(_currentUser.Id, e.Title, e.Content);

            EventManager.Instance.Publish(EventType.PostAdded, this, EventArgs.Empty);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            searchBar.HideResults();
        }

        private void OnNavItemMouseEnter(object? sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label != null)
            {
                label.ForeColor = Color.White;
            }
        }

        private void OnNavItemMouseLeave(object? sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label != null && label != _selectedTab)
            {
                label.ForeColor = Color.FromArgb(178, 172, 162);
            }
        }

        private void lblHomeTab_Click(object sender, EventArgs e)
        {
            ResetNavItemColors();
            lblHomeTab.ForeColor = Color.FromArgb(0, 157, 26);
            _selectedTab = lblHomeTab;
            _navigationService.NavigateToScreen("homeScreen");
        }

        private async void lblMoviesTab_Click(object sender, EventArgs e)
        {
            ResetNavItemColors();
            lblMoviesTab.ForeColor = Color.FromArgb(0, 157, 26);
            _selectedTab = lblMoviesTab;
            _navigationService.NavigateToScreen("moviesScreen");

            await _moviesScreen.LoadMoviesInPageAsync();
        }

        private async void lblListsTab_Click(object sender, EventArgs e)
        {
            ResetNavItemColors();
            lblListsTab.ForeColor = Color.FromArgb(0, 157, 26);
            _selectedTab = lblListsTab;
            _navigationService.NavigateToScreen("listsScreen");

            await _listsScreen.LoadListsAsync();
        }

        private async void lblPostsTab_Click(object sender, EventArgs e)
        {
            ResetNavItemColors();
            lblPostsTab.ForeColor = Color.FromArgb(0, 157, 26);
            _selectedTab = lblPostsTab;
            _navigationService.NavigateToScreen("postsScreen");

            await _postsScreen.LoadPostsAsync();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            // Navigate to homescreen here
            lblHomeTab_Click(this, EventArgs.Empty);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Color newColor = cmsUserDropdown.BackColor;
            btnUser.BackColor = newColor;
            pnUserWrapper.BackColor = newColor;
            cmsUserDropdown.Show(pnUserWrapper, new Point(0, pnUserWrapper.Height));
        }

        private void cmsUserDropdown_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            Color originalColor = Color.FromArgb(0, 138, 22);
            btnUser.BackColor = originalColor;
            pnUserWrapper.BackColor = originalColor;
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileScreen profileScreen = new ProfileScreen(_currentUser);
            _navigationService.NavigateToScreen(profileScreen);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsScreen settingsScreen = new SettingsScreen(_currentUser);
            _navigationService.NavigateToScreen(settingsScreen);
        }
    }
}
