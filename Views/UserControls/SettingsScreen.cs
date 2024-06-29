using CineVerse.Configuration;
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
            picAvatar.Image = (user.AvatarPath != null) ? new Bitmap(user.AvatarPath) : Properties.Resources.default_avatar;
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            _user = user;
        }

        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    string imagesFolderPath = AppSettings.ImagesPath;
                    string avatarDirectory = Path.Combine(imagesFolderPath, "avatars");

                    if (!Directory.Exists(avatarDirectory))
                    {
                        Directory.CreateDirectory(avatarDirectory);
                    }

                    string avatarFileName = $"{_user.Id}{Path.GetExtension(selectedImagePath)}";
                    string avatarFilePath = Path.Combine(avatarDirectory, avatarFileName);

                    File.Copy(selectedImagePath, avatarFilePath, true);

                    _tempAvatarPath = avatarFilePath;
                    picAvatar.Image = new Bitmap(avatarFilePath);
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool isUsernameChanged = _user.Username != txtUsername.Text;
            bool isAvatarChanged = _user.AvatarPath != _tempAvatarPath;

            if (isUsernameChanged)
            {
                _user.Username = txtUsername.Text;
            }

            if (isAvatarChanged)
            {
                _user.AvatarPath = _tempAvatarPath;
            }

            if (isUsernameChanged || isAvatarChanged)
            {
                await UserService.Instance.UpdateUser(_user);
                MessageBox.Show("Succesfully saved your changes", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool IsUnsavedChanges()
        {
            return _user.Username != txtUsername.Text || _tempAvatarPath != _user.AvatarPath;
        }

        private void DiscardChanges()
        {
            txtUsername.Text = _user.Username;
            picAvatar.Image = (_user.AvatarPath != null) ? new Bitmap(_user.AvatarPath) : Properties.Resources.default_avatar;
            _tempAvatarPath = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bool isUsernameChanged = _user.Username != txtUsername.Text;
            bool isAvatarChanged = _user.AvatarPath != _tempAvatarPath;

            if (isUsernameChanged || isAvatarChanged)
            {
                DialogResult result = MessageBox.Show("You have unsaved changes. Do you want to save them before going back?", "Unsaved Changes", MessageBoxButtons.YesNoCancel);
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
                var mainForm = this.FindForm() as MainForm;
                var navService = mainForm.GetNavService();
                navService.NavigateBack();
            }
        }
    }
}
