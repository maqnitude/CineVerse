using CineVerse.Core.Events;
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
    public partial class ReviewItem : UserControl
    {
        public ReviewItem(Review review)
        {
            InitializeComponent();

            Dock = DockStyle.Top;

            SetReviewData(review);

            EventManager.Instance.Subscribe<RatingEventArgs>(EventType.RatingChanged, OnRatingChanged);
        }

        private void SetReviewData(Review review)
        {
            lblUsername.Text = review.User.Name;
            lblRating.Text = review.Rating.ToString();
            lblContent.Text = review.Content;
        }

        private void OnRatingChanged(object sender, RatingEventArgs e)
        {
            lblRating.Text = e.Rating.ToString();
        }
    }
}
