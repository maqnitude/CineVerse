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

namespace CineVerse.Forms
{
    public partial class MainForm : Form, IMediator
    {
        private readonly EventManager _eventManager;
        private readonly MovieBrowsingService _movieBrowsingService;
        private readonly NavigationService _navigationService;

        private readonly MoviesScreen _moviesScreen;

        private User _currentUser;

        public MainForm(EventManager eventManager, MovieBrowsingService movieBrowsingService)
        {
            InitializeComponent();

            _eventManager = eventManager;
            _movieBrowsingService = movieBrowsingService;
            _navigationService = new NavigationService(this, pnMain);

            _moviesScreen = new MoviesScreen(_navigationService, _movieBrowsingService, 12);
            _moviesScreen.SetMediator(this);

            _navigationService.RegisterScreen("moviesScreen", _moviesScreen);

            RegisterEventHandlers();
        }

        public void Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "ShowMoviesScreen":
                    _navigationService.NavigateToScreen("moviesScreen");
                    break;
            }
        }

        private void RegisterEventHandlers()
        {
            _eventManager.Subscribe<UserEventArgs>(EventType.UserSignedIn, OnUserSignedIn);
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
        }

        private async void btnMoviesTab_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnMoviesTab.BackColor = Color.FromArgb(0, 157, 26);
            Notify(this, "ShowMoviesScreen");

            await _moviesScreen.LoadMoviesInPageAsync(_moviesScreen.CurrentPage);
        }
    }
}
