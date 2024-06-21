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
        private User _user;

        public AddToListForm()
        {
            InitializeComponent();
        }

        public void SetUser(User user)
        {
            _user = user;            
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

        private void pnNewList_Click(object sender, EventArgs e)
        {
            // navigate to new list form
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
