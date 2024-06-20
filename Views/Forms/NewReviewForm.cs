using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Views.Forms
{
    public partial class NewReviewForm : Form
    {
        private int rating = 0;
        private bool liked = false;
        private Image darkStar;
        private Image blueStar;
        private Image greenStar;

        public NewReviewForm()
        {
            InitializeComponent();
            InitializeStars();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeStars()
        {
            darkStar = Properties.Resources.star_fill_dark;
            blueStar = Properties.Resources.star_fill_blue;
            greenStar = Properties.Resources.star_fill_green;

            for (int i = 1; i <= 5; i++)
            {
                PictureBox picStar = (PictureBox)pnStars.Controls["picStar" + i];
                picStar.Image = darkStar;
                picStar.Tag = i;
                picStar.MouseEnter += Star_MouseEnter;
                picStar.MouseLeave += Star_MouseLeave;
                picStar.Click += Star_Click;
            }
        }

        private void ResetStarColors()
        {
            for (int i = 1; i <= 5; i++)
            {
                PictureBox picStar = (PictureBox)pnStars.Controls["picStar" + i];
                picStar.Image = darkStar;
            }
        }

        private void Star_MouseEnter(object sender, EventArgs e)
        {
            PictureBox hoveredStar = (PictureBox)sender;
            int hoverIndex = (int)hoveredStar.Tag;
            ResetStarColors();
            for (int i = 1; i <= hoverIndex; i++)
            {
                PictureBox picStar = (PictureBox)pnStars.Controls["picStar" + i];
                if (i <= hoverIndex)
                    picStar.Image = blueStar;
            }
        }

        private void Star_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = (PictureBox)sender;
            rating = (int)clickedStar.Tag;

            for (int i = 1; i <= rating; i++)
            {
                PictureBox picStar = (PictureBox)pnStars.Controls["picStar" + i];
                if (i < rating)
                {
                    picStar.Image = greenStar;
                }
                else
                {
                    picStar.Image = darkStar;
                }
            }

        }

        private void Star_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                PictureBox picStar = (PictureBox)pnStars.Controls["picStar" + i];
                if (i <= rating)
                {
                    picStar.Image = greenStar;
                }
                else
                {
                    picStar.Image = darkStar;
                }
            }
        }

        private void picLike_Click(object sender, EventArgs e)
        {
            liked = !liked;
            picLike.Image = liked ? Properties.Resources.like_fill_orange : Properties.Resources.like_fill_dark;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
