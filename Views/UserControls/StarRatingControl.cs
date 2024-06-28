using CineVerse.Core.Events;
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
    public partial class StarRatingControl : UserControl
    {
        private int _rating = 0;
        private Image _darkStar;
        private Image _blueStar;
        private Image _greenStar;

        public int Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
                UpdateStarImages();
            }
        }

        public StarRatingControl()
        {
            InitializeComponent();
            InitializeStars();
        }

        private void InitializeStars()
        {
            _darkStar = Properties.Resources.star_fill_dark;
            _blueStar = Properties.Resources.star_fill_blue;
            _greenStar = Properties.Resources.star_fill_green;

            for (int i = 1; i <= 5; i++)
            {
                PictureBox picStar = (PictureBox)Controls["picStar" + i];
                picStar.Image = _darkStar;
                picStar.Tag = i;
                picStar.MouseEnter += Star_MouseEnter;
                picStar.MouseLeave += Star_MouseLeave;
                picStar.Click += Star_Click;
            }
        }

        private void UpdateStarImages()
        {
            for (int i = 1; i <= 5; i++)
            {
                PictureBox picStar = (PictureBox)Controls["picStar" + i];
                if (i <= _rating)
                {
                    picStar.Image = _greenStar;
                }
                else
                {
                    picStar.Image = _darkStar;
                }
            }
        }

        private void ResetStarColors()
        {
            for (int i = 1; i <= 5; i++)
            {
                PictureBox picStar = (PictureBox)Controls["picStar" + i];
                picStar.Image = _darkStar;
            }
        }

        private void Star_MouseEnter(object sender, EventArgs e)
        {
            PictureBox hoveredStar = (PictureBox)sender;
            int hoverIndex = (int)hoveredStar.Tag;
            ResetStarColors();
            for (int i = 1; i <= hoverIndex; i++)
            {
                PictureBox picStar = (PictureBox)Controls["picStar" + i];
                if (i <= hoverIndex)
                    picStar.Image = _blueStar;
            }
        }

        private void Star_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = (PictureBox)sender;
            Rating = (int)clickedStar.Tag;
            EventManager.Instance.Publish(EventType.StarClicked, this, EventArgs.Empty);
        }

        private void Star_MouseLeave(object sender, EventArgs e)
        {
            UpdateStarImages();
        }
    }
}
