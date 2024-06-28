﻿using CineVerse.Core.Interfaces;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
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
    public partial class MovieCard : UserControlComponent
    {
        private PictureBox _poster;
        private readonly NavigationService _navigationService;
        public Movie CurrentMovie { get; private set; }

        public MovieCard(NavigationService navigationService)
        {
            InitializeComponent();

            _navigationService = navigationService;

            _poster = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill,
            };
            pnMoviePoster.Controls.Add(_poster);
            _poster.SendToBack();

            SetSize("medium");

            SetupEvents(this);
        }

        private void SetupEvents(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control != null)
                {
                    control.MouseEnter += MovieCard_MouseEnter;
                    control.MouseLeave += MovieCard_MouseLeave;
                    if (control.Parent != pnActions)
                    {
                        control.Click += MovieCard_Click;
                    }
                    SetupEvents(control);
                }
            }
        }

        public void SetMovieData(Movie movie)
        {
            _poster.Image?.Dispose();
            _poster.Image = new Bitmap(movie.PosterPath);
            lblMovieTitle.Text = movie.Title;
            CurrentMovie = movie;
        }

        /// <summary>
        /// Set size of movie card using preset sizes: <c>"small"</c>, <c>"medium"</c>, or <c>"big"</c>
        /// </summary>
        /// <param name="preset"></param>
        public void SetSize(string preset)
        {
            switch (preset)
            {
                case "small":
                    this.Size = new Size(70, 105);
                    pnActions.Size = new Size(63, 24);
                    break;
                case "medium":
                    this.Size = new Size(150, 225);
                    pnActions.Size = new Size(84, 28);
                    break;
                case "big":
                    this.Size = new Size(230, 345);
                    pnActions.Size = new Size(84, 28);
                    break;
            }
        }

        private void MovieCard_MouseEnter(object sender, EventArgs e)
        {
            if (!pnActions.Visible)
            {
                pnActions.Visible = true;
            }
        }

        private void MovieCard_MouseLeave(object sender, EventArgs e)
        {
            Point pt = this.PointToClient(Control.MousePosition);

            if (!this.ClientRectangle.Contains(pt))
            {
                if (pnActions.Visible)
                {
                    pnActions.Visible = false;
                }
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            cmsActions.Show(btnMore, new Point(0, btnMore.Height));
        }

        private void MovieCard_Click(object sender, EventArgs e)
        {
            var movieDetailsScreen = new MovieDetailsScreen(_navigationService);
            movieDetailsScreen.SetMediator(_mediator);
            movieDetailsScreen.SetMovieData(CurrentMovie);
            _navigationService.NavigateToScreen(movieDetailsScreen, false);
        }

        private void addToListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mediator?.Notify(this, "OpenAddToListForm");
        }
    }
}
