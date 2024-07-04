using CineVerse.Core.Events;
using CineVerse.Core.Interfaces;
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
    public partial class ListDetailsScreen : UserControlComponent
    {
        private readonly List _list;

        public ListDetailsScreen(List list)
        {
            InitializeComponent();

            _list = list;

            picUser.SizeMode = PictureBoxSizeMode.StretchImage;

            LoadListData();

            EventManager.Instance.Subscribe<ListMovieEventArgs>(EventType.ListMovieRemoved, OnListMovieRemoved);
        }

        private async void LoadListData()
        {
            lblListTitle.Text = _list.Name;
            lblListOverview.Text = _list.Overview;
            lblUser.Text = _list.User.Username;

            picUser.Image?.Dispose();
            if (_list.User.AvatarPath != null )
            {
                picUser.Image = new Bitmap(_list.User.AvatarPath);
            }

            await LoadMovieCards();
        }

        public void RemoveMovieCards()
        {
            // Avoid modifying the collection that we're iterating over
            List<MovieCard> cardsToRemove = new List<MovieCard>();

            foreach (Control control in flpMovieCards.Controls)
            {
                if (control is MovieCard card)
                {
                    cardsToRemove.Add(card);
                }
            }

            foreach (MovieCard card in cardsToRemove)
            {
                flpMovieCards.Controls.Remove(card);
            }
        }

        private async Task LoadMovieCards()
        {
            flpMovieCards.SuspendLayout();

            RemoveMovieCards();

            List<Movie> movies = await ListService.Instance.GetMoviesFromListAsync(_list.Id);

            foreach (Movie movie in movies)
            {
                var mainForm = this.FindForm() as MainForm;

                MovieCard card = new MovieCard();
                await card.Initialize(mainForm, movie, _mediator);
                card.SetList(_list);
                card.SetSize("medium");

                flpMovieCards.Controls.Add(card);
            }

            flpMovieCards.ResumeLayout();
        }

        private void OnListMovieRemoved(object sender, ListMovieEventArgs e)
        {
            if (e.ListIds.Contains(_list.Id) && e.MovieId != null)
            {
                // Find the movie card with that MovieId and get rid of it
                MovieCard cardToRemove = null;

                foreach (Control control in flpMovieCards.Controls)
                {
                    if (control is MovieCard card && card.Movie.Id == e.MovieId)
                    {
                        cardToRemove = card;
                    }
                }

                if (cardToRemove != null)
                {
                    flpMovieCards.Controls.Remove(cardToRemove);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainForm;
            var navService = mainForm.GetNavService();

            navService.NavigateBack();
        }
    }
}
