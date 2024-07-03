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
        private readonly Image _darkLStar;
        private readonly Image _darkRStar;
        private readonly Image _blueLStar;
        private readonly Image _blueRStar;
        private readonly Image _greenLStar;
        private readonly Image _greenRStar;

        private double _rating = 0;
        public double Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
                UpdateStarImages();
            }
        }
        
        private bool _canSaveRating = true;
        public bool CanSaveRating
        {
            get { return _canSaveRating; }
            set { _canSaveRating = value; }
        }

        public StarRatingControl()
        {
            InitializeComponent();
            
            _darkLStar = Properties.Resources.star_l;
            _darkRStar = Properties.Resources.star_r;

            _blueLStar = Properties.Resources.star_l_blue;
            _blueRStar = Properties.Resources.star_r_blue;

            _greenLStar = Properties.Resources.star_l_green;
            _greenRStar = Properties.Resources.star_r_green;
            
            InitializeStars();
        }

        private void InitializeStars()
        {
            for (int i = 1; i <= 10; i++)
            {
                PictureBox picHalfStar = (PictureBox)Controls["picHalfStar" + i];
                picHalfStar.Image = (i % 2 != 0) ? _darkLStar : _darkRStar;
                picHalfStar.Tag = i / 2.0;
                picHalfStar.MouseEnter += HalfStar_MouseEnter;
                picHalfStar.MouseLeave += HalfStar_MouseLeave;
                picHalfStar.Click += HalfStar_Click;
            }
        }

        private void UpdateStarImages()
        {
            for (int i = 1; i <= 10; i++)
            {
                PictureBox picHalfStar = (PictureBox)Controls["picHalfStar" + i];
                if ((double)picHalfStar.Tag <= _rating)
                {
                    picHalfStar.Image = (i % 2 != 0) ? _greenLStar : _greenRStar;
                }
                else
                {
                    picHalfStar.Image = (i % 2 != 0) ? _darkLStar: _darkRStar;
                }
            }
        }

        private void ResetStarColors()
        {
            for (int i = 1; i <= 10; i++)
            {
                PictureBox picHalfStar = (PictureBox)Controls["picHalfStar" + i];
                picHalfStar.Image = (i % 2 != 0) ? _darkLStar : _darkRStar;
            }
        }

        private void HalfStar_MouseEnter(object sender, EventArgs e)
        {
            PictureBox hoveredHalfStar = (PictureBox)sender;
            int hoverIndex = (int)((double)hoveredHalfStar.Tag * 2);
            ResetStarColors();
            for (int i = 1; i <= hoverIndex; i++)
            {
                PictureBox picHalfStar = (PictureBox)Controls["picHalfStar" + i];
                picHalfStar.Image = (i % 2 != 0) ? _blueLStar : _blueRStar;
            }
        }

        private void HalfStar_Click(object sender, EventArgs e)
        {
            PictureBox clickedHalfStar = (PictureBox)sender;
            Rating = (double)clickedHalfStar.Tag;

            EventManager.Instance.Publish(EventType.RatingChanged, this, new RatingEventArgs(Rating));
        }

        private void HalfStar_MouseLeave(object sender, EventArgs e)
        {
            UpdateStarImages();
        }
    }
}
