using CineVerse.Configuration;
using CineVerse.Core.Events;
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

namespace CineVerse.Views.UserControls
{
    public partial class SettingsScreen : UserControl
    {
        private User _user;
        private string? _tempAvatarPath;

        public SettingsScreen()
        {
            InitializeComponent();
        }

        public void SetUserData(User user)
        {
            txtUsername.Text = user.Username;
            txtEmail.Text = user.Email;
            txtEmail.Enabled = false;
            LoadAvatarImage(user.AvatarPath);
            _user = user;
            _tempAvatarPath = null;
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool isUsernameChanged = _user.Username != txtUsername.Text;
            bool isAvatarChanged = _tempAvatarPath != null && _user.AvatarPath != _tempAvatarPath;

            if (isUsernameChanged)
            {
                _user.Username = txtUsername.Text;
            }

            if (isAvatarChanged)
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

            if (isUsernameChanged || isAvatarChanged)
            {
                await UserService.Instance.UpdateUser(_user.Id, _user);
                EventManager.Instance.Publish(EventType.UserSettingsChanged, this, EventArgs.Empty);
                MessageBox.Show("Succesfully saved your changes", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool IsUnsavedChanges()
        {
            return _user.Username != txtUsername.Text || _tempAvatarPath != null;
        }

        private void DiscardChanges()
        {
            txtUsername.Text = _user.Username;
            LoadAvatarImage(_user.AvatarPath);
            _tempAvatarPath = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (IsUnsavedChanges())
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
