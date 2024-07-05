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

        private bool _currentUserOnly = false;

        private string? _filterBy;
        private string? _filterValue;
        private string? _sortBy;
        private string? _sortValue;

        public bool CurrentUserOnly
        {
            get { return _currentUserOnly; }
            set { _currentUserOnly = value; }
        }

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

            foreach (Control control in pnListsContainer.Controls)
            {
                if (control is ListItemSummary item)
                {
                    itemsToRemove.Add(item);
                }
            }

            foreach (ListItemSummary item in itemsToRemove)
            {
                pnListsContainer.Controls.Remove(item);
                item.DisposeImages();
            }
        }

        public async Task LoadListsAsync()
        {
            pnListsContainer.SuspendLayout();

            ClearLists();

            List<List> lists = new List<List>();
            if (_currentUserOnly)
            {
                lists = await ListService.Instance.GetUserListsAsync(_user.Id, includeUser: true, includeMovies: true,
                    sortBy: _sortBy, sortValue: _sortValue);
            }
            else
            {
                lists = await ListService.Instance.GetListsAsync(ListType.Public, includeUser: true, includeMovies: true,
                    sortBy: _sortBy, sortValue: _sortValue);
            }

            foreach (List list in lists)
            {
                if (list.Id == _user.WatchlistId || list.Id == _user.WatchedListId || list.Id == _user.LikedListId)
                {
                    continue;
                }

                ListItemSummary item = new(list)
                {
                    Dock = DockStyle.Top
                };
                item.SetMediator(_mediator);

                pnListsContainer.Controls.Add(item);
                item.BringToFront();
            }

            pnListsContainer.ResumeLayout();
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

        private async void newestFirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sortBy = "date";
            _sortValue = "newest";

            await LoadListsAsync();
        }

        private async void oldestFirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sortBy = "date";
            _sortValue = "oldest";

            await LoadListsAsync();
        }
    }
}
