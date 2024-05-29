using CineVerse.Configuration;
using CineVerse.Data;
using CineVerse.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Forms
{
    public partial class MainForm : Form
    {
        private Dictionary<PictureBox, Movie> _moviePanels;
        
        public MainForm()
        {
            InitializeComponent();
            _moviePanels = new Dictionary<PictureBox, Movie>();
        }

        private void LoadMovies()
        {
            using (var context = new AppDbContext())
            {
                var movies = context.Movies.Take(10).ToList();
                foreach (var movie in movies)
                {
                    Panel movieContainer = new Panel();
                    PictureBox moviePoster = new PictureBox();
                    moviePoster.Image = Image.FromFile(movie.PosterPath);
                    moviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
                    Label movieTitle = new Label();
                    movieTitle.Text = movie.Title;
                    movieContainer.Controls.Add(movieTitle);
                    movieTitle.Dock = DockStyle.Bottom;
                    movieContainer.Controls.Add(moviePoster);
                    moviePoster.Dock = DockStyle.Fill;

                    panel1.Controls.Add(movieContainer);
                    movieContainer.Dock = DockStyle.Left;

                    _moviePanels[moviePoster] = movie;
                    moviePoster.Click += MovieContainer_Click;
                }
            }
        }

        private void MovieContainer_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            var pictureBox = (PictureBox)sender;
            var movie = _moviePanels[pictureBox];

            using (var context = new AppDbContext())
            {
                var credits = context.Credits.Include(c => c.Person).Where(c => c.MovieId == movie.Id && c.Type == "cast").OrderBy(c => c.Order).Take(10).ToList();
                foreach (Credit credit in credits)
                {
                    Panel creditContainer = new Panel();
                    Label creditLabel = new Label();
                    creditLabel.Text = $"Name: {credit.Person.Name}";
                    PictureBox creditPicture = new PictureBox();
                    if (credit.Person.ProfilePath != null)
                    {
                        creditPicture.Image = Image.FromFile(credit.Person.ProfilePath);
                        creditPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        creditPicture.BackColor = Color.Black;
                    }

                    creditContainer.Controls.Add(creditLabel);
                    creditLabel.Dock = DockStyle.Bottom;
                    creditContainer.Controls.Add(creditPicture);
                    creditPicture.Dock = DockStyle.Fill;

                    panel2.Controls.Add(creditContainer);
                    creditContainer.Dock = DockStyle.Left;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMovies();
        }
    }
}
