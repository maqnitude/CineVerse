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
    public partial class MovieDetailsScreen : UserControl
    {
        public MovieDetailsScreen()
        {
            InitializeComponent();
        }

        private void MovieDetailsScreen_Load(object sender, EventArgs e)
        {
            pnHeader.BackColor = Color.FromArgb(150, 0, 0, 0);
        }
    }
}
