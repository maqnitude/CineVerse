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

namespace CineVerse.Views.UserControls
{
    public partial class PersonCard : UserControl
    {
        private readonly NavigationService _navigationService;
        private Person _person;

        public PersonCard(NavigationService navigationService)
        {
            InitializeComponent();
            _navigationService = navigationService;
            SetupEvents(this);
        }

        private void SetupEvents(Control container)
        {
            foreach (Control child in container.Controls)
            {
                if (child != null)
                {
                    child.Click += PersonCard_Click;
                }
            }
        }

        private void PersonCard_Click(object? sender, EventArgs e)
        {
            var personDetailsScreen = new PersonDetailsScreen(_navigationService);
            personDetailsScreen.SetPersonData(_person);
            _navigationService.NavigateToScreen(personDetailsScreen, false);
        }

        public void SetPersonData(Person person)
        {
            _person = person;
            picProfileImage.Image?.Dispose();
            if (person.ProfilePath != null)
            {
                picProfileImage.Image = new Bitmap(person.ProfilePath);
                picProfileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                picProfileImage.Image = Properties.Resources.default_person;
                picProfileImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
            lblName.Text = person.Name;
        }
    }
}
