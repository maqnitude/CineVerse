using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Forms;
using Microsoft.VisualBasic.Devices;
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
    public partial class SearchResultMovieItem : UserControlComponent
    {
        private Movie _movie;

        public SearchResultMovieItem()
        {
            InitializeComponent();
            RegisterEventHandlers(this);
        }

        public async void SetMovieData(Movie movie)
        {
            _movie = movie;

            lblTitle.Text = movie.Title;
            string releaseYear = movie.ReleaseDate.HasValue ? movie.ReleaseDate.Value.Year.ToString() : "N/A";
            lblReleaseYear.Text = $"({releaseYear})";

            var directors = await MovieService.Instance.GetMovieDirectors(_movie.Id);
            string directorNames = string.Join(", ", directors.Select(d => d.Name));
            lblDirectors.Text = directorNames;
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
            var mainForm = this.FindForm() as MainForm;
            var navService = mainForm.GetNavService();

            var movieDetailsScreen = new MovieDetailsScreen();
            await movieDetailsScreen.Initialize(mainForm, _movie, _mediator);
            navService.NavigateToScreen(movieDetailsScreen, false);

            _mediator?.Notify(this, "HideSearchResults");
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
