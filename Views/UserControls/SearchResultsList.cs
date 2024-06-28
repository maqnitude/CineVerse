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
    public partial class SearchResultsList : UserControlComponent
    {
        public SearchResultsList()
        {
            InitializeComponent();
        }

        public void LoadResultsMovies(List<Movie> movies)
        {
            pnlResults.SuspendLayout();

            ClearResults();

            foreach (Movie movie in movies)
            {
                var item = new SearchResultMovieItem(movie)
                {
                    Dock = DockStyle.Top,
                };
                item.SetMediator(_mediator);
                
                pnlResults.Controls.Add(item);
            }

            pnlResults.ResumeLayout();
        }

        private void ClearResults()
        {
            List<SearchResultMovieItem> movieResultItems = new List<SearchResultMovieItem>();

            foreach (Control control in pnlResults.Controls)
            {
                if (control is SearchResultMovieItem item)
                {
                    movieResultItems.Add(item);
                }
            }

            foreach (SearchResultMovieItem item in movieResultItems)
            {
                pnlResults.Controls.Remove(item);
            }
        }
    }
}
