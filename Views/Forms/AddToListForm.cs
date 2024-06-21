using CineVerse.Core.Events;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Views.Forms
{
    public partial class AddToListForm : Form
    {
        private readonly User _user;
        private readonly Movie _movie;

        public AddToListForm(User user, Movie movie)
        {
            InitializeComponent();

            _user = user;
            _movie = movie;

            EventManager.Instance.Subscribe<EventArgs>(EventType.ListMovieAdded, OnListMovieAdded);
        }

        public async void LoadListsAsync()
        {
            List<List> lists = await ListService.Instance.GetUserListsAsync(_user.Id, false);

            foreach (List list in lists)
            {
                ListItemBasic listItem = new(list)
                {
                    Dock = DockStyle.Top,
                };
                pnFormBody.Controls.Add(listItem);
            }
        }

        private void OnListMovieAdded(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnNewList_Click(object sender, EventArgs e)
        {
            // navigate to new list form
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> listIds = new List<string>();

            foreach (Control control in pnFormBody.Controls)
            {
                if (control is ListItemBasic item && item.IsChecked())
                {
                    listIds.Add(item.GetListId());
                }
            }

            if (listIds.Count == 0)
            {
                MessageBox.Show("No list selected");
                return;
            }

            EventManager.Instance.Publish(EventType.ListMovieAdding, this,
                new ListMovieEventArgs(listIds, _movie.Id));
        }
    }
}
