using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Services
{
    public class NavigationService
    {
        private readonly Dictionary<string, UserControl> _screens;
        private readonly Form _currentForm;
        private readonly Panel _mainPanel;

        public NavigationService(Form currentForm, Panel mainPanel)
        {
            _currentForm = currentForm ?? throw new ArgumentNullException(nameof(currentForm));
            _mainPanel = mainPanel ?? throw new ArgumentNullException(nameof(_mainPanel));
            _screens = new Dictionary<string, UserControl>();
        }

        public void RegisterScreen(string key, UserControl screen)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentException("Key cannot be null or whitespace.", nameof(key));
            }
            if (screen == null)
            {
                throw new ArgumentException(nameof(screen));
            }

            if (_screens.ContainsKey(key))
            {
                throw new InvalidOperationException($"A user control with the key '{key}' is already registered.");
            }
            _screens[key] = screen;
        }

        public void NavigateToScreen(string key)
        {
            if (!_screens.ContainsKey(key))
            {
                throw new KeyNotFoundException($"No screen is registered with the key '{key}'.");
            }

            var screen = _screens[key];
            _mainPanel.Controls.Clear();
            _mainPanel.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
        }
    }
}
