using CineVerse.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Views.UserControls
{
    public class UserControlComponent : UserControl
    {
        protected IMediator _mediator;

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
