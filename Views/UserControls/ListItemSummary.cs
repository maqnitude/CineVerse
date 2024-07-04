using CineVerse.Core.Events;
using CineVerse.Data;
using CineVerse.Data.Entities;
using CineVerse.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CineVerse.Views.UserControls
{
    public partial class ListItemSummary : UserControlComponent
    {
        private List _list;

        public ListItemSummary(List list)
        {
            InitializeComponent();

            _list = list;

            picUserAvatar.SizeMode = PictureBoxSizeMode.StretchImage;

            LoadListData();

            RegisterEventHandlers();
        }

        public string GetListId()
        {
            return _list.Id;
        }

        public void DisposeImages()
        {
            foreach (PictureBox pictureBox in pnPosters.Controls)
            {
                pictureBox.Image?.Dispose();
            }
        }

        public void LoadListData()
        {
            if (_list != null)
            {
                var moviesToDisplay = _list.Movies.Take(5).ToList();

                for (int i = 0; i < moviesToDisplay.Count; i++)
                {
                    var movie = moviesToDisplay[i].Movie;
                    var picPoster = (PictureBox)pnPosters.Controls["picPoster" + (i + 1)];

                    if (picPoster != null)
                    {
                        picPoster.Image?.Dispose();

                        //picPoster.Image = new Bitmap(movie.PosterPath);
                        using (var originalImage = new Bitmap(movie.PosterPath))
                        {
                            // Adjust this value to scale the image. 
                            float scaleFactor = 0.1f;
                            
                            int newWidth = (int)(originalImage.Width * scaleFactor);
                            int newHeight = (int)(originalImage.Height * scaleFactor);
                            
                            var resizedImage = new Bitmap(newWidth, newHeight);
                            using (var graphics = Graphics.FromImage(resizedImage))
                            {
                                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                            }
                            
                            picPoster.Image = new Bitmap(resizedImage);
                        }

                        picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }

                lblListTitle.Text = _list.Name;
                lblUsername.Text = _list.User.Username;
                lblListDescription.Text = _list.Overview;
                lblNumMovies.Text = $"{_list.Movies.Count} films";

                // This causes System.ArgumentException: Parameter is not valid

                //picUserAvatar.Image?.Dispose();
                //if (_list.User.AvatarPath != null)
                //{
                //    picUserAvatar.Image = new Bitmap(_list.User.AvatarPath);
                //}
            }
        }

        private void RegisterEventHandlers()
        {
            this.Click += OnClick;

            foreach (Control control in this.Controls)
            {
                control.Click += OnClick;
            }

            foreach (Control control in pnPosters.Controls)
            {
                control.Click += OnClick;
            }
        }

        private async void OnClick(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainForm;
            var navService = mainForm.GetNavService();

            var listDetailsScreen = new ListDetailsScreen();
            
            navService.NavigateToScreen(listDetailsScreen, false);

            await listDetailsScreen.Initialize(mainForm, _list, _mediator);
        }
    }
}
