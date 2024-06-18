using CineVerse.Core.Events;
using CineVerse.Core.Interfaces;
using CineVerse.Data;
using CineVerse.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

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
            // Scoped
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();

            // Transients
            services.AddTransient<Forms.AuthenticationForm>();

            // Singletons
            services.AddSingleton<EventManager>();
        }
    }
}