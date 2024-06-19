using CineVerse.Core.Events;
using CineVerse.Core.Interfaces;
using CineVerse.Core.Services;
using CineVerse.Data;
using CineVerse.Data.Repositories;
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

            //Application.Run(new Views.Forms.TestForm());

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var testForm = serviceProvider.GetRequiredService<Views.Forms.TestForm>();

                Application.Run(testForm);

                //var mainForm = serviceProvider.GetRequiredService<Forms.MainForm>();
                //mainForm.Hide();

                //var authForm = serviceProvider.GetRequiredService<Forms.AuthenticationForm>();
                //authForm.ShowDialog();

                //Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Register AppDbContext
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

            // Scoped
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();

            // Transients
            services.AddTransient<Views.Forms.TestForm>();
            services.AddTransient<Forms.AuthenticationForm>();
            services.AddTransient<Forms.MainForm>();

            // Singletons
            services.AddSingleton<EventManager>();
            services.AddSingleton<AuthenticationService>();
        }
    }
}