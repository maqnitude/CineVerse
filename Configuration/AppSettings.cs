using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Configuration
{
    internal static class AppSettings
    {
        public static string StartupPath { get; } = Application.StartupPath;
        public static string ImagesPath { get; } = Path.GetFullPath(Path.Combine(AppSettings.StartupPath, "..\\..\\..\\Data\\data\\images"));
    }
}
