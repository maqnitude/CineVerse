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
        private List _list;

        private PictureBox _poster;

        private bool _isMovieInWatchlist = false;
        private bool _isMovieWatched = false;
        private bool _isMovieLiked = false;

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

            EventManager.Instance.Subscribe<EventArgs>(EventType.WatchedListMovieAdded, OnWatchedListMovieAdded);
            EventManager.Instance.Subscribe<EventArgs>(EventType.WatchedListMovieRemoved, OnWatchedListMovieRemoved);

            EventManager.Instance.Subscribe<EventArgs>(EventType.LikedListMovieAdded, OnLikedListMovieAdded);
            EventManager.Instance.Subscribe<EventArgs>(EventType.LikedListMovieRemoved, OnLikedListMovieRemoved);
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

        public async Task Initialize(MainForm mainForm, Movie movie, IMediator mediator)
        {
            SetMainForm(mainForm);
            await SetMovieData(movie);
            SetMediator(mediator);
        }

        public void SetMainForm(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void SetList(List list)
        {
            _list = list;

            var user = _mainForm.GetCurrentUser();
            if (user.Id == _list.User.Id)
            {
                removeFromThisListToolStripMenuItem.Visible = true;
            }
        }

        public async Task SetMovieData(Movie movie)
        {
            _movie = movie;

            _poster.Image?.Dispose();
            _poster.Image = new Bitmap(_movie.PosterPath);
            lblMovieTitle.Text = _movie.Title;

            await UpdateState();
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

        private async Task UpdateContextMenu()
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

        private async Task UpdateActionIcons()
        {
            var user = _mainForm.GetCurrentUser();
            _isMovieWatched = await MovieService.Instance.IsMovieInListAsync(user.WatchedListId, _movie.Id);
            _isMovieLiked = await MovieService.Instance.IsMovieInListAsync(user.LikedListId, _movie.Id);

            if (_isMovieLiked)
            {
                btnLike.Image?.Dispose();
                btnLike.Image = Properties.Resources.liked;
            }
            else
            {
                btnLike.Image?.Dispose();
                btnLike.Image = Properties.Resources.like;
            }

            if (_isMovieWatched)
            {
                btnWatch.Image?.Dispose();
                btnWatch.Image = Properties.Resources.eye_green;
            }
            else
            {
                btnWatch.Image?.Dispose();
                btnWatch.Image = Properties.Resources.eye;
            }
        }

        private async Task UpdateState()
        {
            if (_mainForm != null)
            {
                await UpdateContextMenu();
                await UpdateActionIcons();
            }
        }

        private async void OnWatchlistMovieAdded(object sender, EventArgs e)
        {
            await UpdateState();
        }

        private async void OnWatchlistMovieRemoved(object sender, EventArgs e)
        {
            await UpdateState();
        }

        private async void OnWatchedListMovieAdded(object sender, EventArgs e)
        {
            await UpdateState();
        }

        private async void OnWatchedListMovieRemoved(object sender, EventArgs e)
        {
            await UpdateState();
        }

        private async void OnLikedListMovieAdded(object sender, EventArgs e)
        {
            await UpdateState();
        }

        private async void OnLikedListMovieRemoved(object sender, EventArgs e)
        {
            await UpdateState();
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

        private async void MovieCard_Click(object sender, EventArgs e)
        {
            var navService = _mainForm.GetNavService();

            var movieDetailsScreen = new MovieDetailsScreen();
            await movieDetailsScreen.Initialize(_mainForm, Movie, _mediator);

            navService.NavigateToScreen(movieDetailsScreen, false);
        }

        private void addToListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mediator?.Notify(this, "OpenAddToListForm");
        }

        private async void btnWatch_Click(object sender, EventArgs e)
        {
            var user = _mainForm.GetCurrentUser();

            if (_isMovieWatched)
            {
                await ListService.Instance.RemoveMovieFromWatchedListAsync(user.WatchedListId, user.LikedListId, _movie.Id);
            }
            else
            {
                await ListService.Instance.AddMovieToWatchedListAsync(user.WatchedListId, user.WatchlistId, user.LikedListId, _movie.Id);
            }
        }

        private async void btnLike_Click(object sender, EventArgs e)
        {
            var user = _mainForm.GetCurrentUser();

            if (_isMovieLiked)
            {
                await ListService.Instance.RemoveMovieFromLikedListAsync(user.LikedListId, _movie.Id);
            }
            else
            {
                await ListService.Instance.AddMovieToLikedListAsync(user.LikedListId, user.WatchlistId, user.WatchedListId, _movie.Id);
            }
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

        private async void removeFromThisListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ListService.Instance.RemoveMovieFromListsAsync([_list.Id], _movie.Id);
        }
    }
}
