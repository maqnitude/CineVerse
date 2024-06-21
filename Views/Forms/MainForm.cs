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

        private readonly MoviesScreen _moviesScreen;
        private readonly ListsScreen _listsScreen;

        private User _currentUser;

        public MainForm()
        {
            InitializeComponent();

            _navigationService = new NavigationService(this, pnMain);

            _moviesScreen = new MoviesScreen(_navigationService, 12);
            _listsScreen = new ListsScreen();

            _moviesScreen.SetMediator(this);
            _listsScreen.SetMediator(this);

            _navigationService.RegisterScreen("moviesScreen", _moviesScreen);
            _navigationService.RegisterScreen("listsScreen", _listsScreen);

            RegisterEventHandlers();
        }

        public void Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "OpenAddToListForm":
                    var addToListForm = new AddToListForm();
                    addToListForm.SetUser(_currentUser);
                    addToListForm.LoadListsAsync();
                    addToListForm.ShowDialog();
                    break;
            }
        }

        private void RegisterEventHandlers()
        {
            EventManager.Instance.Subscribe<UserEventArgs>(EventType.UserSignedIn, OnUserSignedIn);

            EventManager.Instance.Subscribe<ListEventArgs>(EventType.ListAdding, OnListAdding);

            EventManager.Instance.Subscribe<ReviewEventArgs>(EventType.ReviewAdding, OnReviewAdding);
        }

        private void ResetButtonColors()
        {
            foreach (Control control in pnNavBar.Controls)
            {
                if (control is Button btn)
                {
                    if (btn.Name != "btnUser")
                        btn.BackColor = Color.FromArgb(150, 150, 150);
                }
            }
        }

        private void OnUserSignedIn(object sender, UserEventArgs e)
        {
            this.Show();

            _currentUser = e.User;

            btnUser.Text = _currentUser.Name;

            _listsScreen.SetUser(_currentUser);
        }

        private async void OnListAdding(object sender, ListEventArgs e)
        {
            await ListService.Instance.AddListAsync(_currentUser.Id, e.Name, e.Type, e.Description);

            EventManager.Instance.Publish(EventType.ListAdded, this, EventArgs.Empty);
        }

        private async void OnReviewAdding(object sender, ReviewEventArgs e)
        {
            await MovieService.Instance.AddMovieReviewAsync(_currentUser.Id, e.MovieId, e.Rating, e.Content);

            EventManager.Instance.Publish(EventType.ReviewAdded, this, EventArgs.Empty);
        }

        private async void btnMoviesTab_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnMoviesTab.BackColor = Color.FromArgb(0, 157, 26);

            _navigationService.NavigateToScreen("moviesScreen");

            await _moviesScreen.LoadMoviesInPageAsync(_moviesScreen.CurrentPage);
        }

        private async void btnListsTab_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnListsTab.BackColor = Color.FromArgb(0, 157, 26);

            _navigationService.NavigateToScreen("listsScreen");

            await _listsScreen.LoadListsAsync();
        }
    }
}
