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
using CineVerse.Core.Services;
using CineVerse.Core.Events;

namespace CineVerse.Forms
{
    public partial class MainForm : Form
    {
        private readonly EventManager _eventManager;
        private readonly NavigationService _navigationService;

        private Dictionary<PictureBox, Movie> _moviePanels;

        public MainForm(EventManager eventManager)
        {
            InitializeComponent();

            _eventManager = eventManager;

            RegisterEventHandlers();
        }

        private void RegisterEventHandlers()
        {
            _eventManager.Subscribe(EventType.UserSignedIn, OnUserSignedIn);
        }

        private void OnUserSignedIn(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
