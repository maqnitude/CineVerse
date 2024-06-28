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
    public partial class MoviesScreen : UserControlComponent
    {
        private readonly NavigationService _navigationService;
        private readonly List<MovieCard> _movieCards;
        private readonly int _moviesPerPage;

        private bool _isLastPage = false;

        private string? _filterBy;
        private string? _filterValue;
        private string? _sortBy;
        private string? _sortValue;

        public int CurrentPage { get; private set; } = 1;

        public MoviesScreen(NavigationService navigationService, int moviesPerPage)
        {
            InitializeComponent();

            _navigationService = navigationService;

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

        public int MoviesPerPage()
        {
            return _moviesPerPage;
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

        public async Task LoadMoviesInPageAsync()
        {
            flpMovieCardsContainer.SuspendLayout();

            RemoveMovieCards();

            List<Movie> movies = await MovieService.Instance.GetMoviesAsync(CurrentPage, _moviesPerPage, _filterBy, _filterValue, _sortBy, _sortValue);

            if (movies.Count > 0)
            {
                for (int i = 0; i < movies.Count; i++)
                {
                    MovieCard card = _movieCards[i];
                    card.SetMainForm(this.FindForm() as MainForm);
                    card.SetMovieData(movies[i]);
                    card.SetMediator(_mediator);
                    card.SetSize("big");

                    flpMovieCardsContainer.Controls.Add(card);
                }
            }

            _isLastPage = (CurrentPage - 1) * _moviesPerPage > movies.Count;

            btnNextPage.Enabled = !_isLastPage;
            btnPrevPage.Enabled = CurrentPage > 1;

            flpMovieCardsContainer.ResumeLayout();
        }

        // Next/Previous buttons

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            lblPageNumber.Text = CurrentPage.ToString();

            await LoadMoviesInPageAsync();

            btnPrevPage.Enabled = true;
        }

        private async void btnPrevPage_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            lblPageNumber.Text = CurrentPage.ToString();

            await LoadMoviesInPageAsync();

            btnPrevPage.Enabled = CurrentPage > 1;
        }

        // Filter by decade

        private async void toolStripMenuItemAll_Click(object sender, EventArgs e)
        {
            _filterBy = "decade";
            _filterValue = "all";

            CurrentPage = 1;
            await LoadMoviesInPageAsync();
        }

        private async void toolStripMenuItemUpcoming_Click(object sender, EventArgs e)
        {
            _filterBy = "decade";
            _filterValue = "upcoming";

            CurrentPage = 1;
            await LoadMoviesInPageAsync();
        }

        private async void toolStripMenuItem2020s_Click(object sender, EventArgs e)
        {
            _filterBy = "decade";
            _filterValue = toolStripMenuItem2020s.Text;

            CurrentPage = 1;
            await LoadMoviesInPageAsync();
        }

        private async void toolStripMenuItem2010s_Click(object sender, EventArgs e)
        {
            _filterBy = "decade";
            _filterValue = toolStripMenuItem2010s.Text;

            CurrentPage = 1;
            await LoadMoviesInPageAsync();
        }

        private async void toolStripMenuItem2000s_Click(object sender, EventArgs e)
        {
            _filterBy = "decade";
            _filterValue = toolStripMenuItem2000s.Text;

            CurrentPage = 1;
            await LoadMoviesInPageAsync();
        }

        private async void toolStripMenuItem1990s_Click(object sender, EventArgs e)
        {
            _filterBy = "decade";
            _filterValue = toolStripMenuItem1990s.Text;

            CurrentPage = 1;
            await LoadMoviesInPageAsync();
        }

        private async void toolStripMenuItem1980s_Click(object sender, EventArgs e)
        {
            _filterBy = "decade";
            _filterValue = toolStripMenuItem1980s.Text;

            CurrentPage = 1;
            await LoadMoviesInPageAsync();
        }

        // Sort by rating

        private async void toolStripMenuItemHighest_Click(object sender, EventArgs e)
        {
            _sortBy = "rating";
            _sortValue = toolStripMenuItemHighest.Text;

            CurrentPage = 1;
            await LoadMoviesInPageAsync();
        }

        private async void toolStripMenuItemLowest_Click(object sender, EventArgs e)
        {
            _sortBy = "rating";
            _sortValue = toolStripMenuItemLowest.Text;

            CurrentPage = 1;
            await LoadMoviesInPageAsync();
        }
    }
}
