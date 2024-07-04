using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Core.Services
{
    public class NavigationService
    {
        private readonly Form _currentForm;
        private readonly Panel _mainPanel;
        private readonly Dictionary<string, UserControl> _screens;
        private readonly Stack<(UserControl Screen, bool Docked)> _navigationStack;

        public NavigationService(Form currentForm, Panel mainPanel)
        {
            _currentForm = currentForm ?? throw new ArgumentNullException(nameof(currentForm));
            _mainPanel = mainPanel ?? throw new ArgumentNullException(nameof(_mainPanel));
            _screens = new Dictionary<string, UserControl>();
            _navigationStack = new Stack<(UserControl, bool)>();
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

            _navigationStack.Push((screen, true));
        }

        public void NavigateToScreen(UserControl screen, bool dockFill = true)
        {
            _mainPanel.Controls.Clear();
            _mainPanel.Controls.Add(screen);
            if (dockFill)
            {
                screen.Dock = DockStyle.Fill;
            }
            else
            {
                screen.Dock = DockStyle.None;
                screen.Location = new Point(0, 0);
                screen.Width = _mainPanel.ClientSize.Width;
                screen.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            }

            _navigationStack.Push((screen, dockFill));
        }

        public void NavigateBack()
        {
            if (_navigationStack.Count > 1)
            {
                var (currentScreen, _) = _navigationStack.Pop();
                currentScreen.Dispose();

                var (previousScreen, docked) = _navigationStack.Peek();

                _mainPanel.Controls.Clear();
                _mainPanel.Controls.Add(previousScreen);

                if (docked)
                {
                    previousScreen.Dock = DockStyle.Fill;
                }
                else
                {
                    previousScreen.Dock = DockStyle.None;
                    previousScreen.Location = new Point(0, 0);
                    previousScreen.Width = _mainPanel.ClientSize.Width;
                    previousScreen.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
                }
            }
            else
            {
                throw new InvalidOperationException("Cannot go back from the first screen.");
            }
        }
    }
}
