using CineVerse.Core.Events;
using CineVerse.Core.Services;
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

namespace CineVerse.Views.Forms
{
    public partial class NewListForm : Form
    {
        private class ComboBoxItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public NewListForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            List<ComboBoxItem> items = new()
            {
                new ComboBoxItem { Id = 0, Name = "Anyone - Public list" },
                new ComboBoxItem { Id = 1, Name = "Only you - Private list" },
            };
            comboListType.DataSource = items;
            comboListType.DisplayMember = "Name";
            comboListType.ValueMember = "Id";

            EventManager.Instance.Subscribe<EventArgs>(EventType.ListAdded, OnListAdded);
        }

        private ListType MapListType(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    return ListType.Public;
                case 1:
                    return ListType.Private;
                default:
                    throw new ArgumentOutOfRangeException(nameof(selectedIndex), "Invalid list type selected.");
            }
        }

        private void OnListAdded(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("List name must not be empty.");
                return;
            }

            if (comboListType.SelectedIndex == -1)
            {
                MessageBox.Show("Please specify the visibility of your list.");
                return;
            }

            EventManager.Instance.Publish<ListAddEventArgs>(EventType.ListAdding, this,
                new ListAddEventArgs(txtName.Text, txtDescription.Text, MapListType(comboListType.SelectedIndex)));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
