using CineVerse.Core.Interfaces;
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
    public partial class MoviesScreen : UserControl
    {
        public MoviesScreen()
        {
            InitializeComponent();
        }

        public void LoadMovies(List<Movie> movies)
        {
            foreach (Movie movie in movies)
            {
                MovieCard card = new(movie);
                flpMovieCardsContainer.Controls.Add(card);
            }
        }
    }
}
