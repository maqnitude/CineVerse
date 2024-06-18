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

            //Application.Run(new Forms.AuthenticationForm());

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                Application.Run(serviceProvider.GetRequiredService<Forms.AuthenticationForm>());
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

            // Transients
            services.AddTransient<Forms.AuthenticationForm>();

            // Singletons
            services.AddSingleton<EventManager>();
            services.AddSingleton<AuthenticationService>();
        }
    }
}