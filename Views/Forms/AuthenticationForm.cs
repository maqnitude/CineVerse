using CineVerse.Core.Interfaces;
using CineVerse.Data;
using CineVerse.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Forms
{
    public partial class AuthenticationForm : Form, IMediator
    {
        private UserControl? _currentPage;
        private readonly UnitOfWork _unitOfWork;

        public AuthenticationForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            btnSignIn_Click(btnSignIn, EventArgs.Empty);
        }

        public AuthenticationForm(UnitOfWork unitOfWork)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
        }

        public void Notify(object sender, string ev)
        {
            throw new NotImplementedException();
        }

        private void ResetButtonColors()
        {
            foreach (Button btn in pnTabContainer.Controls)
            {
                btn.BackColor = Color.FromArgb(150, 150, 150);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnSignIn.BackColor = Color.FromArgb(0, 157, 26);
            if (_currentPage != null)
            {
                _currentPage.Dispose();
            }
            _currentPage = new SignInPage();
            _currentPage.Dock = DockStyle.Fill;
            pnPageContainer.Controls.Add(_currentPage);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnSignUp.BackColor = Color.FromArgb(0, 157, 26);
            if (_currentPage != null)
            {
                _currentPage.Dispose();
            }
            _currentPage = new SignUpPage();
            _currentPage.Dock = DockStyle.Fill;
            pnPageContainer.Controls.Add(_currentPage);
        }
    }
}
