using CineVerse.Core.Events;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Forms;
using CineVerse.Views.Forms;
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
    public partial class FavouriteMoviePoster : UserControl
    {
        private User _user;
        private Movie? _movie;
        private int _position;

        public FavouriteMoviePoster()
        {
            InitializeComponent();
            RegisterEventHandlers();
        }

        public void SetData(User user, Movie? movie, int position)
        {
            _user = user;
            _movie = movie;
            _position = position;

            picPoster.Image?.Dispose();
            picPoster.Image = (_movie != null) ? new Bitmap(_movie.PosterPath) : Properties.Resources.poster_add_placeholder;
            picPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            SetupEvents();
        }

        private void RegisterEventHandlers()
        {
            EventManager.Instance.Subscribe<FavouriteMovieEventArgs>(EventType.FavouriteMovieChanged, OnFavouriteMovieChanged);
        }

        private void SetupEvents()
        {
            this.Click += Poster_Click;
            picPoster.Click += Poster_Click;
            if (_movie != null)
            {
                AttachEvents();
            }
        }

        private void AttachEvents()
        {
            picPoster.MouseEnter += Poster_MouseEnter;
            picPoster.MouseLeave += Poster_MouseLeave;
            btnRemove.Click += btnRemove_CLick;
            btnRemove.MouseEnter += btnRemove_MouseEnter;
            btnRemove.MouseLeave += btnRemove_MouseLeave;
        }

        private void DetachEvents()
        {
            picPoster.MouseEnter -= Poster_MouseEnter;
            picPoster.MouseLeave -= Poster_MouseLeave;
            btnRemove.Click -= btnRemove_CLick;
            btnRemove.MouseEnter -= btnRemove_MouseEnter;
            btnRemove.MouseLeave -= btnRemove_MouseLeave;
        }

        private void Poster_Click(object? sender, EventArgs e)
        {
            MovieSelectionForm form = new MovieSelectionForm();
            form.SetData(_user, _position);
            form.ShowDialog();
        }

        private void Poster_MouseEnter(object? sender, EventArgs e)
        {
            if (!btnRemove.Visible)
            {
                btnRemove.Visible = true;
                btnRemove.BackColor = Color.Transparent;
                btnRemove.BringToFront();
            }
        }

        private void Poster_MouseLeave(object? sender, EventArgs e)
        {
            Point pt = this.PointToClient(Control.MousePosition);

            if (!this.ClientRectangle.Contains(pt))
            {
                if (btnRemove.Visible)
                {
                    btnRemove.Visible = false;
                }
            }
        }

        private async void btnRemove_CLick(object? sender, EventArgs e)
        {
            await UserService.Instance.RemoveFavouriteMovie(_user.Id, _position);
        }

        private void btnRemove_MouseEnter(object? sender, EventArgs e)
        {
            btnRemove.Image = Properties.Resources.poster_remove_orange;
        }

        private void btnRemove_MouseLeave(object? sender, EventArgs e)
        {
            btnRemove.Image = Properties.Resources.poster_remove;
        }

        private async void OnFavouriteMovieChanged(object? sender, FavouriteMovieEventArgs e)
        {
            int movieId = e.MovieId;
            int position = e.Position;
            if (position == _position)
            {
                if (movieId == -1)
                {
                    picPoster.Image?.Dispose();
                    picPoster.Image = Properties.Resources.poster_add_placeholder;
                    // unsubscribe event handlers
                    if (_movie != null)
                    {
                        DetachEvents();
                        btnRemove.Visible = false;
                    }
                    _movie = null;
                }
                else
                {
                    if (_movie != null && movieId == _movie.Id)
                    {
                        return;
                    }
                    if (_movie == null)
                    {
                        AttachEvents();
                    }
                    _movie = await MovieService.Instance.GetMovieByIdAsync(movieId);
                    picPoster.Image?.Dispose();
                    picPoster.Image = new Bitmap(_movie.PosterPath);
                }
            }
        }
    }
}
