using CineVerse.Core.Events;
using CineVerse.Core.Interfaces;
using CineVerse.Core.Services;
using CineVerse.Data;
using CineVerse.Data.Repositories;
using CineVerse.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace CineVerse
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var mainForm = new Forms.MainForm();
            mainForm.Hide();
            var authForm = new Forms.AuthForm();
            authForm.ShowDialog();
            Application.Run(mainForm);
        }
    }
}