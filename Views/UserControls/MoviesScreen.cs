using CineVerse.Core.Interfaces;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
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
    public partial class MoviesScreen : UserControlComponent
    {
        private readonly MovieBrowsingService _movieBrowsingService;
        private readonly List<MovieCard> _movieCards;
        private readonly int _moviesPerPage;

        public int CurrentPage { get; private set; } = 1;

        public MoviesScreen(MovieBrowsingService movieBrowsingService, int moviesPerPage)
        {
            InitializeComponent();

            _movieBrowsingService = movieBrowsingService;

            // Disable the previous and next page button by default
            btnPrevPage.Enabled = false;
            btnNextPage.Enabled = false;

            // Initialize a fixed set of movie cards
            _moviesPerPage = moviesPerPage;
            _movieCards = new List<MovieCard>();
            for (int i = 0; i < _moviesPerPage; i++)
            {
                _movieCards.Add(new MovieCard());
            }
        }

        public void RemoveMovieCards()
        {
            // Avoid modifying the collection that we're iterating over
            List<MovieCard> cardsToRemove = new List<MovieCard>();

            foreach (Control control in flpMovieCardsContainer.Controls)
            {
                if (control is MovieCard card)
                {
                    cardsToRemove.Add(card);
                }
            }

            foreach (MovieCard card in cardsToRemove)
            {
                flpMovieCardsContainer.Controls.Remove(card);
            }
        }

        public async Task LoadMoviesInPageAsync(int pageNumber)
        {
            flpMovieCardsContainer.SuspendLayout();

            RemoveMovieCards();

            List<Movie> movies = await _movieBrowsingService.GetMoviesInPageAsync(pageNumber, _moviesPerPage);

            Debug.WriteLine(movies.Count);

            if (movies.Count > 0)
            {
                for (int i = 0; i < movies.Count; i++)
                {
                    MovieCard card = _movieCards[i];
                    card.SetMovieData(movies[i]);
                    flpMovieCardsContainer.Controls.Add(card);
                }
            }

            bool isLastPage = await _movieBrowsingService.IsLastPage(CurrentPage, _moviesPerPage);
            btnNextPage.Enabled = !isLastPage;
            btnPrevPage.Enabled = CurrentPage > 1;

            flpMovieCardsContainer.ResumeLayout();
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            await LoadMoviesInPageAsync(CurrentPage);

            btnPrevPage.Enabled = true;
        }

        private async void btnPrevPage_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            await LoadMoviesInPageAsync(CurrentPage);

            btnPrevPage.Enabled = CurrentPage > 1;
        }
    }
}
