using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CineVerse.Views.UserControls
{
    public partial class PersonDetailsScreen : UserControlComponent
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
            //picProfile.Image = (person.ProfilePath != null) ? new Bitmap(person.ProfilePath) : Properties.Resources.default_person;
            if (person.ProfilePath != null)
            {
                using (var originalImage = new Bitmap(person.ProfilePath))
                {
                    // Adjust this value to scale the image. 
                    float scaleFactor = 0.5f;
                    
                    int newWidth = (int)(originalImage.Width * scaleFactor);
                    int newHeight = (int)(originalImage.Height * scaleFactor);
                    
                    var resizedImage = new Bitmap(newWidth, newHeight);
                    using (var graphics = Graphics.FromImage(resizedImage))
                    {
                        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                    }
                    
                    picProfile.Image = new Bitmap(resizedImage);
                }
            }
            else
            {
                picProfile.Image = Properties.Resources.default_person;
            }

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
                var mainForm = this.FindForm() as MainForm;

                MovieCard card = new MovieCard();
                await card.Initialize(mainForm, movie, _mediator);
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
