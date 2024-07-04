using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Views.Forms;
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
    public partial class SelectableMovieItem : UserControlComponent
    {
        private Movie _movie;

        public SelectableMovieItem()
        {
            InitializeComponent();
            RegisterEventHandlers(this);
        }

        public async void SetMovieData(Movie movie)
        {
            _movie = movie;

            picMoviePoster.Image?.Dispose();
            //picMoviePoster.Image = new Bitmap(_movie.PosterPath);
            using (var originalImage = new Bitmap(_movie.PosterPath))
            {
                // Adjust this value to scale the image. 
                // For example, 0.5 will make the image half its original size.
                float scaleFactor = 0.05f;
                
                int newWidth = (int)(originalImage.Width * scaleFactor);
                int newHeight = (int)(originalImage.Height * scaleFactor);
                
                var resizedImage = new Bitmap(newWidth, newHeight);
                using (var graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                }
                
                picMoviePoster.Image = new Bitmap(resizedImage);
            }

            picMoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;

            string year = _movie.ReleaseDate.HasValue ? _movie.ReleaseDate.Value.Year.ToString() : "N/A";
            lblMovieTitle.Text = $"{_movie.Title} ({year})";

            var director = await MovieService.Instance.GetMovieDirectorAsync(_movie.Id);
            lblDirector.Text = director.Name;
        }

        private void RegisterEventHandlers(Control parentControl)
        {
            parentControl.Click += OnClick;
            parentControl.MouseEnter += OnMouseEnter;
            parentControl.MouseLeave += OnMouseLeave;

            foreach (Control childControl in parentControl.Controls)
            {
                RegisterEventHandlers(childControl);
            }
        }

        private async void OnClick(object? sender, EventArgs e)
        {
            var movieSelectionForm = this.FindForm() as MovieSelectionForm;
            if (movieSelectionForm != null && _movie != null)
            {
                movieSelectionForm.Submit(_movie);
            }
        }

        private void OnMouseEnter(object? sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 138, 22);
        }

        private void OnMouseLeave(object? sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
