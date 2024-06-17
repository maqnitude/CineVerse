using CineVerse.Core.Interfaces;
using CineVerse.Data;
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
        private readonly UnitOfWork _unitOfWork;

        public AuthenticationForm(UnitOfWork unitOfWork)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
        }

        public void Notify(object sender, string ev)
        {
            throw new NotImplementedException();
        }
    }
}
