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
    public partial class ListItemBasic : UserControl
    {
        private bool isChecked = false;
        public ListItemBasic(List list)
        {
            InitializeComponent();
            SetListData(list);
        }

        public void SetListData(List list)
        {
            lblListTitle.Text = list.Name;
            picListType.Image = list.Type == ListType.Private ? Properties.Resources._lock : null;
        }

        private void ListItemBasic_Click(object sender, EventArgs e)
        {
            isChecked = !isChecked;
            this.BackColor = isChecked ? Color.FromArgb(41, 54, 68) : Color.FromArgb(54, 68, 82);
            this.picCheck.Image = isChecked ? Properties.Resources.check : null;
        }
    }
}
