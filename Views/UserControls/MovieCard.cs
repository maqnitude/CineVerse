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
    public partial class MovieCard : UserControl
    {
        public MovieCard(Movie movie)
        {
            InitializeComponent();

            PictureBox poster = new()
            {
                Image = new Bitmap(movie.PosterPath),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            poster.Dock = DockStyle.Fill;
            pnMoviePoster.Controls.Add(poster);
            poster.SendToBack();

            lblMovieTitle.Text = movie.Title;

            SetupEvents(this);
        }
        
        private void SetupEvents(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control != null)
                {
                    Debug.WriteLine(control);
                    control.MouseEnter += MovieCard_MouseEnter;
                    control.MouseLeave += MovieCard_MouseLeave;
                    SetupEvents(control);
                }
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
    }
}
