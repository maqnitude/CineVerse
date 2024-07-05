using CineVerse.Core.Events;
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
    public partial class NewPostForm : Form
    {
        public NewPostForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            EventManager.Instance.Subscribe<EventArgs>(EventType.PostAdded, OnPostAdded);
        }

        private void OnPostAdded(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is empty");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("Content is empty");
                return;
            }

            EventManager.Instance.Publish(EventType.PostAdding, this,
                new PostEventArgs(txtTitle.Text, txtContent.Text));
        }
    }
}
