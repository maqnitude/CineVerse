using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineVerse.Core.Events;
using CineVerse.Core.Interfaces;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Views.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace CineVerse.Views.UserControls
{
    public partial class MovieDetailsScreen : UserControlComponent
    {
        private readonly NavigationService _navigationService;
        private Movie _movie;

        public MovieDetailsScreen(NavigationService navigationService)
        {
            InitializeComponent();
            _navigationService = navigationService;

            EventManager.Instance.Subscribe<EventArgs>(EventType.ReviewAdded, OnReviewAdded);
        }

        public Movie GetCurrentMovie()
        {
            return _movie;
        }

        public void SetMovieData(Movie movie)
        {
            _movie = movie;

            lblMovieTitle.Text = movie.Title;

            pnBackdrop.BackgroundImage?.Dispose();
            pnBackdrop.BackgroundImage = new Bitmap(movie.BackdropPath);

            picMoviePoster.Image?.Dispose();
            picMoviePoster.Image = new Bitmap(movie.PosterPath);

            lblReleaseYear.Text = movie.ReleaseDate?.Year.ToString();
            lblReleaseDate.Text = movie.ReleaseDate.ToString();

            lblGenres.Text = String.Join(", ", movie.Genres);
            lblRuntime.Text = $"{movie.Runtime / 60}h{movie.Runtime % 60}m";

            lblTagline.Text = movie.TagLine.ToUpper();
            lblOverviewParagraph.Text = movie.Overview;

            lblStatus.Text = movie.Status;
            lblOriginalLanguage.Text = movie.OriginalLanguage;
            lblBudget.Text = movie.Budget.ToString();
            lblRevenue.Text = movie.Revenue.ToString();

            LoadCredits();
            LoadReviews();
        }

        private void ClearReviews()
        {
            List<ReviewItem> reviewItemsToRemove = new List<ReviewItem>();

            foreach (Control control in pnReviews.Controls)
            {
                if (control is ReviewItem reviewItem)
                {
                    reviewItemsToRemove.Add(reviewItem);
                }
            }

            foreach (ReviewItem reviewItem in reviewItemsToRemove)
            {
                pnReviews.Controls.Remove(reviewItem);
            }
        }

        private async void LoadReviews()
        {
            ClearReviews();

            List<Review> reviews = await ReviewService.Instance.GetMovieReviewsAsync(_movie.Id);

            foreach (Review review in reviews)
            {
                ReviewItem reviewItem = new(review);
                pnReviews.Controls.Add(reviewItem);
            }
        }

        private async void LoadCredits()
        {
            List<Person> casts = await MovieService.Instance.GetTopCastsByMovieIdAsync(_movie.Id, 10);

            foreach (Person cast in casts)
            {
                PersonCard castItem = new(_navigationService);
                castItem.SetPersonData(cast);
                pnCasts.Controls.Add(castItem);
                castItem.BringToFront();
                castItem.Dock = DockStyle.Left;
            }

            List<Person> crews = await MovieService.Instance.GetTopCrewsByMovieIdAsync(_movie.Id, 10);
            foreach (Person crew in crews)
            {
                PersonCard crewItem = new(_navigationService);
                crewItem.SetPersonData(crew);
                pnCrews.Controls.Add(crewItem);
                crewItem.BringToFront();
                crewItem.Dock = DockStyle.Left;
            }
        }

        private void OnReviewAdded(object sender, EventArgs e)
        {
            LoadReviews();
        }

        private void MovieDetailsScreen_Load(object sender, EventArgs e)
        {
            pnHeader.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnHeaderInfo.BackColor = Color.Transparent;
            pnMovieTitle.BackColor = Color.Transparent;
            pnMovieFacts.BackColor = Color.Transparent;
            pnDirector.BackColor = Color.Transparent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateBack();
        }

        private void lblReviewOrLog_Click(object sender, EventArgs e)
        {
            var newReviewForm = new NewReviewForm(_movie);
            newReviewForm.ShowDialog();
        }

        private void lblAddToLists_Click(object sender, EventArgs e)
        {
            _mediator?.Notify(this, "OpenAddToListForm");
        }
    }
}
