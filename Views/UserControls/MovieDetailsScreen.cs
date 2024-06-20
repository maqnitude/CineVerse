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

namespace CineVerse.Views.UserControls
{
    public partial class MovieDetailsScreen : UserControl
    {
        private readonly NavigationService _navigationService;

        public MovieDetailsScreen(NavigationService navigationService)
        {
            InitializeComponent();
            _navigationService = navigationService;
        }

        public void SetMovieData(Movie movie)
        {
            pnBackdrop.BackgroundImage?.Dispose();
            picMoviePoster.Image?.Dispose();
            pnBackdrop.BackgroundImage = new Bitmap(movie.BackdropPath);
            picMoviePoster.Image = new Bitmap(movie.PosterPath);
            lblMovieTitle.Text = movie.Title;
        }

        private void MovieDetailsScreen_Load(object sender, EventArgs e)
        {
            //pnHeader.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateBack();
        }
    }
}
