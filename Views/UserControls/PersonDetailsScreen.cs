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
    public partial class PersonDetailsScreen : UserControl
    {
        private readonly NavigationService _navigationService;
        private Person _person;

        public PersonDetailsScreen(NavigationService navigationService)
        {
            InitializeComponent();
            _navigationService = navigationService;
        }

        public void SetPersonData(Person person)
        {
            _person = person;
            lblName.Text = person.Name;
            picProfile.Image?.Dispose();
            picProfile.Image = (person.ProfilePath != null) ? new Bitmap(person.ProfilePath) : Properties.Resources.default_person;
            txtBiography.Text = person.Biography;
            lblExperise.Text = person.MainExpertise;
            lblGender.Text = person.Gender.ToString();
            lblPlaceOfBirth.Text = person.PlaceOfBirth;
            if (person.BirthDay.HasValue)
            {
                DateTime birthDate = person.BirthDay.Value;
                string formattedBirthday = birthDate.ToString("MMMM dd, yyyy");

                int age = CalculateAge(birthDate);
                lblBirthday.Text = $"{formattedBirthday} ({age} years old)";
            }
            else
            {
                lblBirthday.Text = string.Empty;
            }
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;

            LoadMovieCardsAsync();
        }

        private async Task LoadMovieCardsAsync()
        {
            List<Movie> movies = await PersonService.Instance.GetTopMoviesByPersonId(_person.Id);
            foreach (Movie movie in movies)
            {
                MovieCard card = new MovieCard();
                card.SetMovieData(movie);
                card.SetSize("medium");
                pnMovieCards.Controls.Add(card);
                card.BringToFront();
                card.Dock = DockStyle.Left;
            }
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthDate.Year;
            if (now < birthDate.AddYears(age)) // Adjust age if birthday hasn't occurred yet this year
            {
                age--;
            }
            return age;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateBack();
        }
    }
}
