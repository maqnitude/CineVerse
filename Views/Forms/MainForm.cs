using CineVerse.Configuration;
using CineVerse.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineVerse.Data.Entities;

namespace CineVerse.Forms
{
    public partial class MainForm : Form
    {
        private Dictionary<PictureBox, Movie> _moviePanels;
        
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
