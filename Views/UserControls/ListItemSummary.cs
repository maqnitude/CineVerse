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

namespace CineVerse.Views.UserControls
{
    public partial class ListItemSummary : UserControl
    {
        private List _list;

        public ListItemSummary(List list)
        {
            InitializeComponent();

            _list = list;

            LoadListData(_list);

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

        public void LoadListData(List list)
        {
            _list = list;

            if (_list != null)
            {
                var moviesToDisplay = _list.Movies.Take(5).ToList();

                for (int i = 0; i < moviesToDisplay.Count; i++)
                {
                    var movie = moviesToDisplay[i].Movie;
                    var picPoster = (PictureBox)pnPosters.Controls["picPoster" + (i + 1)];

                    //if (picPoster != null)
                    //{
                    //    if (picPoster.Image != null)
                    //    {
                    //        picPoster.Image.Dispose();
                    //        picPoster.Image = null;
                    //    }

                    //    try
                    //    {
                    //        picPoster.Image = new Bitmap(movie.PosterPath);
                    //        picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        MessageBox.Show($"There is an error while loading movie images: {ex}");
                    //        picPoster.Image = null;
                    //    }
                    //}

                    if (picPoster != null)
                    {
                        picPoster.Image?.Dispose();

                        picPoster.Image = new Bitmap(movie.PosterPath);
                        picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    //picPoster?.SendToBack();
                }

                lblListTitle.Text = _list.Name;
                lblUsername.Text = _list.User.Username;
                lblListDescription.Text = _list.Overview;
                lblNumMovies.Text = $"{_list.Movies.Count} films";
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

        private void OnClick(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainForm;
            var navService = mainForm.GetNavService();

            var listDetailsScreen = new ListDetailsScreen(_list);
            
            navService.NavigateToScreen(listDetailsScreen, false);
        }
    }
}
