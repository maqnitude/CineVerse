using CineVerse.Core.Services;
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
        public AddToListForm()
        {
            InitializeComponent();
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
