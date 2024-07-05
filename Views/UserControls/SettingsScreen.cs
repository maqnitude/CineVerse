using CineVerse.Configuration;
using CineVerse.Core.Events;
using CineVerse.Core.Services;
using CineVerse.Data.Entities;
using CineVerse.Data.Repositories;
using CineVerse.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Views.UserControls
{
    public partial class SettingsScreen : UserControl
    {
        private User _user;
        private string? _tempAvatarPath;

        public SettingsScreen(User user)
        {
            InitializeComponent();
            SetUserData(user);
        }

        public void SetUserData(User user)
        {
            _user = user;

            txtUsername.Text = user.Username;
            
            txtEmail.Text = user.Email;
            txtEmail.Enabled = false;

            txtGivenName.Text = user.GivenName;
            txtFamilyName.Text = user.FamilyName;
            txtLocation.Text = user.Location;
            txtWebsite.Text = user.Website;
            txtBio.Text = user.Bio;
            cbbVisibility.SelectedItem = user.ProfileVisibility.ToString();

            LoadAvatarImage(user.AvatarPath);
            _tempAvatarPath = null;

            LoadPosters();
        }

        private async void LoadPosters()
        {
            List<Movie?> movies = await UserService.Instance.GetFavouriteMovies(_user);
            for (int i = 0; i < 4; i++)
            {
                string controlName = $"poster{i}";
                var poster = pnFavouriteMoviePosters.Controls.Find(controlName, true).FirstOrDefault() as FavouriteMoviePoster;
                if (poster != null && i <= movies.Count)
                {
                    poster.SetData(_user, movies[i], i);
                }
            }
        }

        private void LoadAvatarImage(string avatarPath)
        {
            if (picAvatar.Image != null)
            {
                picAvatar.Image.Dispose();
            }

            if (avatarPath != null)
            {
                try
                {
                    using (FileStream fs = new FileStream(avatarPath, FileMode.Open, FileAccess.Read))
                    {
                        picAvatar.Image = Image.FromStream(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (_user.AvatarPath != null)
                    {
                        using (FileStream fs = new FileStream(_user.AvatarPath, FileMode.Open, FileAccess.Read))
                        {
                            picAvatar.Image = Image.FromStream(fs);
                        }
                    }
                    else
                    {
                        picAvatar.Image = Properties.Resources.default_avatar;
                    }
                }
            }
            else
            {
                picAvatar.Image = Properties.Resources.default_avatar;
            }

            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    LoadAvatarImage(selectedImagePath);
                    _tempAvatarPath = selectedImagePath;
                }
            }
        }

        private ProfileVisibility ParseProfileVisibility(string visibility)
        {
            return visibility switch
            {
                "Private" => ProfileVisibility.Private,
                "Public" => ProfileVisibility.Public,
                "Friends" => ProfileVisibility.Friends,
                _ => throw new Exception("Invalid profile visibility"),
            };
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!HasUnsavedChanges())
            {
                return;
            }
            _user.Username = txtUsername.Text;
            _user.ProfileVisibility = ParseProfileVisibility(cbbVisibility.Text);
            _user.GivenName = txtGivenName.Text;
            _user.FamilyName = txtFamilyName.Text;
            _user.Location = txtLocation.Text;
            _user.Website = txtWebsite.Text;
            _user.Bio = txtBio.Text;

            if (_tempAvatarPath != null && _user.AvatarPath != _tempAvatarPath)
            {
                string imagesFolderPath = AppSettings.ImagesPath;
                string avatarDirectory = Path.Combine(imagesFolderPath, "avatars");
                
                if (!Directory.Exists(avatarDirectory))
                {
                    Directory.CreateDirectory(avatarDirectory);
                }

                string avatarFileName = $"{_user.Id}{Path.GetExtension(_tempAvatarPath)}";
                string avatarFilePath = Path.Combine(avatarDirectory, avatarFileName);

                if (File.Exists(avatarFilePath))
                {
                    File.Delete(avatarFilePath);
                }

                File.Copy(_tempAvatarPath, avatarFilePath);
                _user.AvatarPath = avatarFilePath;
                _tempAvatarPath = null;
            }

            await UserService.Instance.UpdateUser(_user.Id, _user);
            EventManager.Instance.Publish(EventType.UserSettingsChanged, this, EventArgs.Empty);
            MessageBox.Show("Succesfully saved your changes", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool HasUnsavedChanges()
        {
            return _user.Username != txtUsername.Text ||
                   _tempAvatarPath != null ||
                   (_user.GivenName ?? string.Empty) != txtGivenName.Text ||
                   (_user.FamilyName ?? string.Empty) != txtFamilyName.Text ||
                   (_user.Location ?? string.Empty) != txtLocation.Text ||
                   (_user.Website ?? string.Empty) != txtWebsite.Text ||
                   (_user.Bio ?? string.Empty) != txtBio.Text ||
                   _user.ProfileVisibility.ToString() != cbbVisibility.Text;
        }

        private void DiscardChanges()
        {
            SetUserData(_user);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (HasUnsavedChanges())
            {
                DialogResult result = MessageBox.Show("Do you want to save your unsaved changes before going back?", "Unsaved Changes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    btnSave_Click(this, EventArgs.Empty);
                }
                else if (result == DialogResult.No)
                {
                    DiscardChanges();
                }
                else
                {
                    return;
                }
            }

            var mainForm = this.FindForm() as MainForm;
            var navService = mainForm.GetNavService();
            navService.NavigateBack();
        }
    }
}
