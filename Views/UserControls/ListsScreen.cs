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
    public partial class ListsScreen : UserControl
    {
        private User _user;

        public ListsScreen()
        {
            InitializeComponent();

            EventManager.Instance.Subscribe<EventArgs>(EventType.ListAdded, OnListAdded);
        }

        public void SetUser(User user)
        {
            _user = user;
        }

        private void ClearLists()
        {
            List<ListItemSummary> items = new List<ListItemSummary>();

            foreach (Control control in pnlListsContainer.Controls)
            {
                if (control is ListItemSummary item)
                {
                    items.Add(item); 
                }
            }

            foreach (ListItemSummary item in items)
            {
                pnlListsContainer.Controls.Remove(item);
            }
        }

        public async Task LoadListsAsync()
        {
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
        }

        private async void OnListAdded(object sender, EventArgs e)
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
