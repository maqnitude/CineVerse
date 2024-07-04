using CineVerse.Core.Interfaces;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Forms;
using CineVerse.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Views.Forms
{
    public partial class MovieSelectionForm : Form
    {
        private User _user;
        private int _position;
        private SearchResultsList _results;

        public MovieSelectionForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public void SetData(User user, int position)
        {
            _user = user;
            _position = position;
        }

        public async void Submit(Movie movie)
        {
            try
            {

                await UserService.Instance.AddOrUpdateFavouriteMovies(_user.Id, movie.Id, _position);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void txtSearchbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchbox.Text))
            {
                _results.Visible = false;
                return;
            }

            // Create the results list once
            if (_results == null || _results.IsDisposed)
            {
                _results = new SearchResultsList();
                pnResults.Controls.Add(_results);
                _results.Location = new Point(pnSearchbar.Location.X, 0);
                _results.Dock = DockStyle.Fill;
            }

            if (_results != null)
            {
                _results.Show();
                _results.BringToFront();
            }

            List<Movie> movies = await MovieService.Instance.SearchMoviesAsync(txtSearchbox.Text);
            _results.LoadSelectableMovieItems(movies);
        }

        private void txtSearchbox_Enter(object sender, EventArgs e)
        {
            txtSearchbox.BackColor = Color.FromArgb(24, 26, 27);
            pnSearchbar.BackColor = Color.FromArgb(24, 26, 27);
        }

        private void txtSearchbox_Leave(object sender, EventArgs e)
        {
            txtSearchbox.BackColor = Color.FromArgb(43, 47, 49);
            pnSearchbar.BackColor = Color.FromArgb(43, 47, 49);
        }
    }
}
