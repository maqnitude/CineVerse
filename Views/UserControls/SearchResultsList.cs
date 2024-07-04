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

        public void LoadSearchResultMovieItems(List<Movie> movies)
        {
            pnlResults.SuspendLayout();

            ClearSearchResultMovieItems();

            foreach (Movie movie in movies)
            {
                SearchResultMovieItem item = new SearchResultMovieItem
                {
                    Dock = DockStyle.Top,
                };
                item.SetMovieData(movie);
                item.SetMediator(_mediator);
                
                pnlResults.Controls.Add(item);
            }

            pnlResults.ResumeLayout();
        }

        public void LoadSelectableMovieItems(List<Movie> movies)
        {
            pnlResults.SuspendLayout();

            ClearSelectableMovieItems();

            foreach(Movie movie in movies)
            {
                SelectableMovieItem item = new SelectableMovieItem
                {
                    Dock = DockStyle.Top,
                };
                item.SetMovieData(movie);
                item.SetMediator(_mediator);

                pnlResults.Controls.Add(item);
            }

            pnlResults.ResumeLayout();
        }

        private void ClearSearchResultMovieItems()
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

        private void ClearSelectableMovieItems()
        {
            List<SelectableMovieItem> movieItems = new List<SelectableMovieItem>();

            foreach (Control control in pnlResults.Controls)
            {
                if (control is SelectableMovieItem item)
                {
                    movieItems.Add(item);
                }
            }

            foreach(SelectableMovieItem item in movieItems)
            {
                pnlResults.Controls.Remove(item);
            }
        }
    }
}
