using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        public void SetMovieData(Movie movie)
        {
            _movie = movie;

            lblMovieTitle.Text = movie.Title;

            pnBackdrop.BackgroundImage?.Dispose();
            pnBackdrop.BackgroundImage = new Bitmap(movie.BackdropPath);

            picMoviePoster.Image?.Dispose();
            picMoviePoster.Image = new Bitmap(movie.PosterPath);
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
