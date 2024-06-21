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

namespace CineVerse.Views.UserControls
{
    public partial class MovieDetailsScreen : UserControl
    {
        private readonly NavigationService _navigationService;
        private Movie _movie;

        public MovieDetailsScreen(NavigationService navigationService)
        {
            InitializeComponent();
            _navigationService = navigationService;

            EventManager.Instance.Subscribe<EventArgs>(EventType.ReviewAdded, OnReviewAdded);
        }

        public void SetMovieData(Movie movie)
        {
            _movie = movie;

            lblMovieTitle.Text = movie.Title;

            pnBackdrop.BackgroundImage?.Dispose();
            pnBackdrop.BackgroundImage = new Bitmap(movie.BackdropPath);

            picMoviePoster.Image?.Dispose();
            picMoviePoster.Image = new Bitmap(movie.PosterPath);

            //Notify(this, "LoadReviews");
            LoadReviews();
        }

        //public void Notify(object sender, string ev)
        //{
        //    switch (ev)
        //    {
        //        case "LoadReviews":
        //            LoadReviews();
        //            break;
        //    }
        //}

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

        private void OnReviewAdded(object sender, EventArgs e)
        {
            LoadReviews();
        }

        private void MovieDetailsScreen_Load(object sender, EventArgs e)
        {
            //pnHeader.BackColor = Color.FromArgb(150, 0, 0, 0);
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

    }
}
