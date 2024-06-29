using CineVerse.Data.Entities;
using CineVerse.Forms;
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
        private readonly Movie _movie;

        public SearchResultMovieItem(Movie movie)
        {
            InitializeComponent();

            _movie = movie;

            lblTitle.Text = movie.Title;
            if (movie.ReleaseDate != null )
            {
                lblReleaseYear.Text = movie.ReleaseDate.Value.Year.ToString();
            }

            RegisterEventHandlers();
        }

        private void RegisterEventHandlers()
        {
            this.Click += OnClick;
            foreach (Control control in this.Controls)
            {
                control.Click += OnClick;
            }
        }

        private async void OnClick(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainForm;
            var navService = mainForm.GetNavService();

            var movieDetailsScreen = new MovieDetailsScreen();
            await movieDetailsScreen.Initialize(mainForm, _movie, _mediator);
            navService.NavigateToScreen(movieDetailsScreen, false);

            _mediator?.Notify(this, "HideSearchResults");
        }
    }
}
