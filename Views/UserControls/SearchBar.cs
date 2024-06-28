using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Forms;
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
    public partial class SearchBar : UserControlComponent
    {
        private SearchResultsList _results;

        public SearchBar()
        {
            InitializeComponent();
        }

        public void ShowResults()
        {
            if (_results != null)
            {
                _results.Show();
                _results.BringToFront();
            }
        }

        public void HideResults()
        {
            if (_results != null)
            {
                _results.Hide();
            }
        }

        private async void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBox.Text))
            {
                _results.Visible = false;
                return;
            }

            // Create the results list once
            if (_results == null || _results.IsDisposed)
            {
                _results = new SearchResultsList()
                {
                    Width = this.Width,
                    Location = new Point(this.Location.X, this.Location.Y + this.Height),
                };
                _results.SetMediator(_mediator);

                var mainForm = this.FindForm() as MainForm;
                mainForm.Controls.Add(_results);
            }

            ShowResults();

            List<Movie> movies = await MovieService.Instance.SearchMoviesAsync(txtSearchBox.Text);

            _results.LoadResultsMovies(movies);
        }
    }
}
