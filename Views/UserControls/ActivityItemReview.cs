using CineVerse.Data.Entities;
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
    public partial class ActivityItemReview : UserControl
    {
        private Review _review;
        public ActivityItemReview(Review review)
        {
            InitializeComponent();
            SetReviewData(review);
        }

        public void SetReviewData(Review review)
        {
            _review = review;

            lblUsername.Text = review.User.Username;
            lblMovieTitle.Text = review.Movie.Title;
            lblRating.Text = review.Rating.ToString();
            lblBodyText.Text = review.Content;
            picUser.Image?.Dispose();
            picUser.Image = (_review.User.AvatarPath != null) ? new Bitmap(_review.User.AvatarPath) : Properties.Resources.default_avatar_transparent;
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picMoviePoster.Image?.Dispose();
            picMoviePoster.Image = new Bitmap(_review.Movie.PosterPath);
        }
    }
}
