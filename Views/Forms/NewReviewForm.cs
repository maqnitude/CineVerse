using CineVerse.Core.Events;
using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Views.Forms
{
    public partial class NewReviewForm : Form
    {
        private Movie _movie;

        private int _rating = 0;
        private bool _liked = false;

        public NewReviewForm(Movie movie)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            SetMovieData(movie);

            EventManager.Instance.Subscribe<EventArgs>(EventType.ReviewAdded, OnReviewAdded);
            EventManager.Instance.Subscribe<EventArgs>(EventType.RatingChanged, OnRatingChanged);
        }

        private void SetMovieData(Movie movie)
        {
            _movie = movie;

            lblMovieTitle.Text = movie.Title;
            lblReleaseYear.Text = movie.ReleaseDate.Value.Year.ToString();

            picMoviePoster.Image?.Dispose();
            picMoviePoster.Image = new Bitmap(movie.PosterPath);
        }

        private void OnReviewAdded(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnRatingChanged(object sender, EventArgs e)
        {
            _rating = starRatingControl.Rating;

            lblRatingStatus.Text = _rating.ToString() + " out of 5";
        }

        private void picLike_Click(object sender, EventArgs e)
        {
            _liked = !_liked;
            picLike.Image = _liked ? Properties.Resources.like_fill_orange : Properties.Resources.like_fill_dark;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine(_rating);
            //Debug.WriteLine(_liked);
            //Debug.WriteLine(txtReview.Text);
            if (_rating == 0)
            {
                MessageBox.Show("You must rate the movie");
                return;
            }

            EventManager.Instance.Publish(EventType.ReviewAdding, this,
                new ReviewEventArgs(_movie.Id, (double)_rating, txtReview.Text));
        }
    }
}
