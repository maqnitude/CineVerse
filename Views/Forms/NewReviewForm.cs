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

        private Image _darkStar;
        private Image _blueStar;
        private Image _greenStar;

        public NewReviewForm(Movie movie)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            InitializeStars();

            SetMovieData(movie);

            EventManager.Instance.Subscribe<EventArgs>(EventType.ReviewAdded, OnReviewAdded);
        }

        private void SetMovieData(Movie movie)
        {
            _movie = movie;

            lblMovieTitle.Text = movie.Title;
            lblReleaseYear.Text = movie.ReleaseDate.Value.Year.ToString();

            picMoviePoster.Image?.Dispose();
            picMoviePoster.Image = new Bitmap(movie.PosterPath);
        }

        private void InitializeStars()
        {
            _darkStar = Properties.Resources.star_fill_dark;
            _blueStar = Properties.Resources.star_fill_blue;
            _greenStar = Properties.Resources.star_fill_green;

            for (int i = 1; i <= 5; i++)
            {
                PictureBox picStar = (PictureBox)pnStars.Controls["picStar" + i];
                picStar.Image = _darkStar;
                picStar.Tag = i;
                picStar.MouseEnter += Star_MouseEnter;
                picStar.MouseLeave += Star_MouseLeave;
                picStar.Click += Star_Click;
            }
        }

        private void ResetStarColors()
        {
            for (int i = 1; i <= 5; i++)
            {
                PictureBox picStar = (PictureBox)pnStars.Controls["picStar" + i];
                picStar.Image = _darkStar;
            }
        }

        private void Star_MouseEnter(object sender, EventArgs e)
        {
            PictureBox hoveredStar = (PictureBox)sender;
            int hoverIndex = (int)hoveredStar.Tag;
            ResetStarColors();
            for (int i = 1; i <= hoverIndex; i++)
            {
                PictureBox picStar = (PictureBox)pnStars.Controls["picStar" + i];
                if (i <= hoverIndex)
                    picStar.Image = _blueStar;
            }
        }

        private void Star_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = (PictureBox)sender;
            _rating = (int)clickedStar.Tag;

            for (int i = 1; i <= _rating; i++)
            {
                PictureBox picStar = (PictureBox)pnStars.Controls["picStar" + i];
                if (i <= _rating)
                {
                    picStar.Image = _greenStar;
                }
                else
                {
                    picStar.Image = _darkStar;
                }
            }

            if (!lblRatingStatus.Visible)
            {
                lblRatingStatus.Visible = true;
            }
            lblRatingStatus.Text = $"{_rating} out of 5";
        }

        private void Star_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                PictureBox picStar = (PictureBox)pnStars.Controls["picStar" + i];
                if (i <= _rating)
                {
                    picStar.Image = _greenStar;
                }
                else
                {
                    picStar.Image = _darkStar;
                }
            }
        }

        private void OnReviewAdded(object sender, EventArgs e)
        {
            this.Close();
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
