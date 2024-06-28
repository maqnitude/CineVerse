using CineVerse.Core.Events;
using CineVerse.Core.Interfaces;
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
    public partial class MovieCard : UserControlComponent
    {
        private MainForm _mainForm;
        private Movie _movie;

        private PictureBox _poster;

        private bool _isMovieInWatchlist = false;

        public Movie Movie
        {
            get
            {
                return _movie;
            }
        }

        public MovieCard()
        {
            InitializeComponent();

            addToWatchlistToolStripMenuItem.Visible = true;
            removeFromWatchlistToolStripMenuItem.Visible = false;

            _poster = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill,
            };
            pnMoviePoster.Controls.Add(_poster);
            _poster.SendToBack();

            SetSize("medium");

            SetupEvents(this);

            RegisterEventHandlers();
        }

        private void RegisterEventHandlers()
        {
            EventManager.Instance.Subscribe<EventArgs>(EventType.WatchlistMovieAdded, OnWatchlistMovieAdded);
            EventManager.Instance.Subscribe<EventArgs>(EventType.WatchlistMovieRemoved, OnWatchlistMovieRemoved);
        }

        private void SetupEvents(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control != null)
                {
                    control.MouseEnter += MovieCard_MouseEnter;
                    control.MouseLeave += MovieCard_MouseLeave;
                    if (control.Parent != pnActions)
                    {
                        control.Click += MovieCard_Click;
                    }
                    SetupEvents(control);
                }
            }
        }

        public void SetMainForm(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void SetMovieData(Movie movie)
        {
            _movie = movie;

            _poster.Image?.Dispose();
            _poster.Image = new Bitmap(_movie.PosterPath);
            lblMovieTitle.Text = _movie.Title;

            UpdateContextMenu();
        }

        /// <summary>
        /// Set size of movie card using preset sizes: <c>"small"</c>, <c>"medium"</c>, or <c>"big"</c>
        /// </summary>
        /// <param name="preset"></param>
        public void SetSize(string preset)
        {
            switch (preset)
            {
                case "small":
                    lblMovieTitle.Visible = false;
                    this.Size = new Size(76, 111);
                    pnActions.Size = new Size(63, 26);
                    break;
                case "medium":
                    this.Size = new Size(150, 225 + 28);
                    pnActions.Size = new Size(84, 28);
                    break;
                case "big":
                    this.Size = new Size(230, 345 + lblMovieTitle.Height);
                    pnActions.Size = new Size(84, 28);
                    break;
            }
        }

        private async void UpdateContextMenu()
        {
            var user = _mainForm.GetCurrentUser();
            _isMovieInWatchlist = await MovieService.Instance.IsMovieInListAsync(user.WatchlistId, _movie.Id);

            if (_isMovieInWatchlist)
            {
                addToWatchlistToolStripMenuItem.Visible = false;
                removeFromWatchlistToolStripMenuItem.Visible = true;
            }
            else
            {
                addToWatchlistToolStripMenuItem.Visible = true;
                removeFromWatchlistToolStripMenuItem.Visible = false;
            }
        }

        private void MovieCard_MouseEnter(object sender, EventArgs e)
        {
            if (!pnActions.Visible)
            {
                pnActions.Visible = true;
            }
        }

        private void MovieCard_MouseLeave(object sender, EventArgs e)
        {
            Point pt = this.PointToClient(Control.MousePosition);

            if (!this.ClientRectangle.Contains(pt))
            {
                if (pnActions.Visible)
                {
                    pnActions.Visible = false;
                }
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            cmsActions.Show(btnMore, new Point(0, btnMore.Height));
        }

        private void MovieCard_Click(object sender, EventArgs e)
        {
            var navService = _mainForm.GetNavService();

            var movieDetailsScreen = new MovieDetailsScreen(navService);
            movieDetailsScreen.SetMediator(_mediator);
            movieDetailsScreen.SetMovieData(Movie);

            navService.NavigateToScreen(movieDetailsScreen, false);
        }

        private void addToListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mediator?.Notify(this, "OpenAddToListForm");
        }

        private async void addToWatchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = _mainForm.GetCurrentUser();

            await ListService.Instance.AddMovieToWatchlistAsync(user.WatchlistId, user.WatchedListId, user.LikedListId, _movie.Id);
        }

        private async void removeFromWatchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = _mainForm.GetCurrentUser();

            await ListService.Instance.RemoveMovieFromWatchlistAsync(user.WatchlistId, _movie.Id);
        }

        private async void OnWatchlistMovieAdded(object sender, EventArgs e)
        {
            UpdateContextMenu();
        }

        private async void OnWatchlistMovieRemoved(object sender, EventArgs e)
        {
            UpdateContextMenu();
        }
    }
}
