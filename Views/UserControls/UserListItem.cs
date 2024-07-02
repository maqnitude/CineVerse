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
    public partial class UserListItem : UserControl
    {
        private bool _showStatsPanel = true;
        public bool ShowStatsPanel
        {
            get => _showStatsPanel;
            set
            {
                _showStatsPanel=value;
                pnStats.Visible = value;
            }
        }

        public UserListItem()
        {
            InitializeComponent();
        }
    }
}
