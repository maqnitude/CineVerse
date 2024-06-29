using CineVerse.Core.Events;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Views.Forms;
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
    public partial class ListsScreen : UserControlComponent
    {
        private User _user;

        public ListsScreen()
        {
            InitializeComponent();

            EventManager.Instance.Subscribe<EventArgs>(EventType.ListAdded, OnListAdded);
            EventManager.Instance.Subscribe<ListMovieEventArgs>(EventType.ListMovieAdded, OnListMovieAddedRemoved);
            EventManager.Instance.Subscribe<ListMovieEventArgs>(EventType.ListMovieRemoved, OnListMovieAddedRemoved);
        }

        public void SetUser(User user)
        {
            _user = user;
        }

        private void ClearLists()
        {
            List<ListItemSummary> itemsToRemove = new List<ListItemSummary>();

            foreach (Control control in pnlListsContainer.Controls)
            {
                if (control is ListItemSummary item)
                {
                    itemsToRemove.Add(item); 
                }
            }

            foreach (ListItemSummary item in itemsToRemove)
            {
                pnlListsContainer.Controls.Remove(item);
                item.DisposeImages();
            }
        }

        public async Task LoadListsAsync()
        {
            pnlListsContainer.SuspendLayout();

            ClearLists();

            List<List> lists = await ListService.Instance.GetUserListsAsync(_user.Id, true, true);

            foreach (List list in lists)
            {
                ListItemSummary item = new(list)
                {
                    Dock = DockStyle.Top
                };

                pnlListsContainer.Controls.Add(item);
            }

            pnlListsContainer.ResumeLayout();
        }

        private async void OnListAdded(object sender, EventArgs e)
        {
            await LoadListsAsync();
        }

        private async void OnListMovieAddedRemoved(object sender, ListMovieEventArgs e)
        {
            await LoadListsAsync();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            var newListForm = new NewListForm();
            newListForm.ShowDialog();
        }
    }
}
