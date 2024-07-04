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
    public partial class UsersScreen : UserControlComponent
    {
        private User _user;
        public UsersScreen()
        {
            InitializeComponent();
        }

        public void SetUser(User user)
        {
            _user = user;
        }

        public async Task LoadUsersAsync()
        {
            ClearUsersAsync();
            List<User> users = await UserService.Instance.GetPublicUsersAsync();
            foreach (User user in users)
            {
                if (user.Id != _user.Id)
                {
                    UserListItem item = new(user)
                    {
                        Dock = DockStyle.Top,
                    };
                    item.BringToFront();
                    pnPublicMembersList.Controls.Add(item);
                    item.SetCurrentUser(_user);
                    await item.SetStats();
                }
            }
        }

        private async Task ClearUsersAsync()
        {
            foreach (var userListItem in pnPublicMembersList.Controls.OfType<UserListItem>().ToList())
            {
                pnPublicMembersList.Controls.Remove(userListItem);
                userListItem.Dispose();
            }
        }
    }
}
