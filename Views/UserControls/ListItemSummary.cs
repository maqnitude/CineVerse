using CineVerse.Data;
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
    public partial class ListItemSummary : UserControl
    {
        private List? _list;

        public ListItemSummary(List list)
        {
            InitializeComponent();

            SetListData(list);
        }

        public void SetListData(List list)
        {
            _list = list;
            
            if (list != null)
            {
                var moviesToDisplay = _list.Movies.Take(5).ToList();

                for (int i = 0; i < moviesToDisplay.Count; i++)
                {
                    var movie = moviesToDisplay[i].Movie;
                    var picPoster = (PictureBox)pnPosters.Controls["picPoster" + (i + 1)];

                    if (picPoster != null)
                    {
                        if (picPoster.Image != null)
                        {
                            picPoster.Image.Dispose();
                            picPoster.Image = null;
                        }

                        try
                        {
                            picPoster.Image = new Bitmap(movie.PosterPath);
                            picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"There is an error while loading movie images: {ex}");
                            picPoster.Image = null;
                        }
                    }
                }

                lblListTitle.Text = list.Name;
                lblUsername.Text = list.User.Username;
                lblListDescription.Text = list.Overview;
                lblNumMovies.Text = list.Movies.Count.ToString();
            }
        }
    }
}
