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
        private readonly ListService _listService;

        private class ComboBoxItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public NewListForm(ListService listService)
        {
            InitializeComponent();

            _listService = listService;

            List<ComboBoxItem> items = new()
            {
                new ComboBoxItem { Id = 0, Name = "Anyone - Public list" },
                new ComboBoxItem { Id = 1, Name = "Only you - Private list" },
            };
            comboListType.DataSource = items;
            comboListType.DisplayMember = "Name";
            comboListType.ValueMember = "Id";
        }

        private async void btnSave_Click(object sender, EventArgs e)
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

            //MessageBox.Show($"Selected item: {comboListType.SelectedItem} - Index: {comboListType.SelectedIndex}");

            try
            {
                await _listService.CreateListAsync(txtName.Text, MapListType(comboListType.SelectedIndex), txtDescription.Text);
                MessageBox.Show("New list created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
