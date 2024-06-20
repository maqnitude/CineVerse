using CineVerse.Configuration;
using CineVerse.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CineVerse.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<ListMovie> ListMovies { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<MovieCompany> MovieCompanies { get; set; }

        private static List<string> ParseGenres(JsonElement genreElements)
        {
            var genres = new List<string>();
            foreach (var genreElement in genreElements.EnumerateArray())
            {
                if (genreElement.TryGetProperty("name", out var genreName))
                {
                    genres.Add(genreName.GetString());
                }
            }
            return genres;
        }

        private static List<string> ParseOriginCountries(JsonElement countryElements)
        {
            var countries = new List<string>();
            foreach (var countryElement in countryElements.EnumerateArray())
            {
                var country = countryElement.GetString();
                if (!string.IsNullOrEmpty(country))
                {
                    countries.Add(country);
                }
            }
            return countries;
        }

        private static List<string> ParseProductionCountries(JsonElement countryElements)
        {
            var countries = new List<string>();
            foreach (var countryElement in countryElements.EnumerateArray())
            {
                if (countryElement.TryGetProperty("name", out var countryName))
                {
                    countries.Add(countryName.GetString());
                }
            }
            return countries;
        }
        private static List<string> ParseSpokenLanguages(JsonElement languageElements)
        {
            var languages = new List<string>();
            foreach (var languageElement in languageElements.EnumerateArray())
            {
                if (languageElement.TryGetProperty("english_name", out var languageName))
                {
                    languages.Add(languageName.GetString());
                }
            }
            return languages;
        }

        public static Movie ReadMovieData(string filePath)
        {
            var json = File.ReadAllText(filePath);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            var movie = new Movie
            {
                Id = root.GetProperty("id").GetInt32(),
                ImdbId = root.GetProperty("imdb_id").GetString(),
                Title = root.GetProperty("title").GetString(),
                OriginalTitle = root.TryGetProperty("original_title", out var originalTitle) && originalTitle.ValueKind != JsonValueKind.Null ? originalTitle.GetString() : null,
                Overview = root.TryGetProperty("overview", out var overview) && overview.ValueKind != JsonValueKind.Null ? overview.GetString() : null,
                Popularity = root.TryGetProperty("popularity", out var popularity) && popularity.ValueKind != JsonValueKind.Null ? popularity.GetDouble() : default,
                Genres = root.TryGetProperty("genres", out var genres) && genres.ValueKind != JsonValueKind.Null ? ParseGenres(genres) : new List<string>(),
                BackdropPath = root.TryGetProperty("backdrop_path", out var backdropPath) && backdropPath.ValueKind != JsonValueKind.Null ? backdropPath.GetString() : null,
                PosterPath = root.TryGetProperty("poster_path", out var posterPath) && posterPath.ValueKind != JsonValueKind.Null ? posterPath.GetString() : null,
                Budget = root.TryGetProperty("budget", out var budget) && budget.ValueKind != JsonValueKind.Null ? budget.GetInt64() : default,
                Revenue = root.TryGetProperty("revenue", out var revenue) && revenue.ValueKind != JsonValueKind.Null ? revenue.GetInt64() : default,
                Runtime = root.TryGetProperty("runtime", out var runtime) && runtime.ValueKind != JsonValueKind.Null ? runtime.GetInt32() : default,
                ReleaseDate = root.TryGetProperty("release_date", out var releaseDate) && DateTime.TryParse(releaseDate.GetString(), out var parsedReleaseDate) ? DateTime.SpecifyKind(parsedReleaseDate, DateTimeKind.Utc) : (DateTime?)null,
                OriginCountries = root.TryGetProperty("origin_country", out var orgCountries) && orgCountries.ValueKind != JsonValueKind.Null ? ParseOriginCountries(orgCountries) : new List<string>(),
                ProductionCountries = root.TryGetProperty("production_countries", out var prodCountries) && prodCountries.ValueKind != JsonValueKind.Null ? ParseProductionCountries(prodCountries) : new List<string>(),
                OriginalLanguage = root.TryGetProperty("original_language", out var originalLanguage) && originalLanguage.ValueKind != JsonValueKind.Null ? originalLanguage.GetString() : null,
                SpokenLanguages = root.TryGetProperty("spoken_languages", out var languages) && languages.ValueKind != JsonValueKind.Null ? ParseSpokenLanguages(languages) : new List<string>(),
                Status = root.TryGetProperty("status", out var status) && status.ValueKind != JsonValueKind.Null ? status.GetString() : null,
                TagLine = root.TryGetProperty("tagline", out var tagLine) && tagLine.ValueKind != JsonValueKind.Null ? tagLine.GetString() : null,
                Homepage = root.TryGetProperty("homepage", out var homepage) && homepage.ValueKind != JsonValueKind.Null ? homepage.GetString() : null,
                VoteCount = root.TryGetProperty("vote_count", out var voteCount) && voteCount.ValueKind != JsonValueKind.Null ? voteCount.GetInt32() : default,
                VoteAverage = root.TryGetProperty("vote_average", out var voteAverage) && voteAverage.ValueKind != JsonValueKind.Null ? voteAverage.GetDouble() : default,
            };

            movie.PosterPath = Path.Combine(AppSettings.ImagesPath, "posters", movie.PosterPath?.TrimStart('/') ?? string.Empty);
            movie.BackdropPath = Path.Combine(AppSettings.ImagesPath, "backdrops", movie.BackdropPath?.TrimStart('/') ?? string.Empty);
            
            return movie;
        }

        private static List<string> ParseOtherNames(JsonElement otherNames)
        {
            var names = new List<string>();
            foreach (var name in otherNames.EnumerateArray())
            {
                names.Add(name.GetString());
            }
            return names;
        }

        public static Person ReadPersonData(string filePath)
        {
            var json = File.ReadAllText(filePath);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            var person = new Person
            {
                Id = root.GetProperty("id").GetInt32(),
                ImdbId = root.GetProperty("imdb_id").GetString(),
                Name = root.GetProperty("name").GetString(),
                OtherNames = root.TryGetProperty("also_known_as", out var otherNames) && otherNames.ValueKind != JsonValueKind.Null ? ParseOtherNames(otherNames) : new List<string>(),
                Biography = root.TryGetProperty("biography", out var biography) && biography.ValueKind != JsonValueKind.Null ? biography.GetString() : null,
                Gender = root.TryGetProperty("gender", out var gender) && gender.ValueKind != JsonValueKind.Null ? (Gender)gender.GetInt16() : Gender.NotSpecified,
                ProfilePath = root.TryGetProperty("profile_path", out var profilePath) && profilePath.ValueKind != JsonValueKind.Null ? Path.Combine(AppSettings.ImagesPath, "profiles", profilePath.GetString().TrimStart('/')) : null,
                PlaceOfBirth = root.TryGetProperty("place_of_birth", out var placeOfBirth) && placeOfBirth.ValueKind != JsonValueKind.Null ? placeOfBirth.GetString() : null,
                BirthDay = root.TryGetProperty("birthday", out var birthday) && DateTime.TryParse(birthday.GetString(), out var parsedBirthday) ? DateTime.SpecifyKind(parsedBirthday, DateTimeKind.Utc) : (DateTime?)null,
                DeathDay = root.TryGetProperty("deathday", out var deathday) && DateTime.TryParse(deathday.GetString(), out var parsedDeathday) ? DateTime.SpecifyKind(parsedDeathday, DateTimeKind.Utc) : (DateTime?)null,
                Popularity = root.TryGetProperty("popularity", out var popularity) && popularity.ValueKind != JsonValueKind.Null ? popularity.GetDouble() : default,
                MainExpertise = root.GetProperty("known_for_department").GetString(),
                Homepage = root.TryGetProperty("homepage", out var homepage) && homepage.ValueKind != JsonValueKind.Null ? homepage.GetString() : null,

            };

            return person;
        }
        
        public static Credit ReadCreditData(string filePath)
        {
            var json = File.ReadAllText(filePath);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            var credit = new Credit
            {
                Id = root.GetProperty("id").GetString(),
                Type = root.TryGetProperty("credit_type", out var type) && type.ValueKind != JsonValueKind.Null ? type.GetString() : null,
                MovieId = root.GetProperty("media").GetProperty("id").GetInt32(),
                PersonId = root.GetProperty("person").GetProperty("id").GetInt32(),
                Department = root.TryGetProperty("department", out var department) && department.ValueKind != JsonValueKind.Null ? department.GetString() : null,
                Job = root.TryGetProperty("job", out var job) && job.ValueKind != JsonValueKind.Null ? job.GetString() : null,
            };
            if (credit.Type == "cast")
            {
                credit.Character = root.TryGetProperty("media", out var media) && media.ValueKind != JsonValueKind.Null ? media.GetProperty("character").GetString() : null;
                credit.Order = root.TryGetProperty("order", out var order) ? order.GetInt32() : default;
            }

            return credit;
        }

        public static Company ReadCompanyData(string filePath)
        {
            var json = File.ReadAllText(filePath);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            var company = new Company
            {
                Id = root.GetProperty("id").GetInt32(),
                Name = root.GetProperty("name").GetString(),
                Country = root.TryGetProperty("origin_country", out var country) && country.ValueKind != JsonValueKind.Null ? country.GetString() : null,
                Description = root.TryGetProperty("description", out var description) && description.ValueKind != JsonValueKind.Null ? description.GetString() : null,
                Headquarters = root.TryGetProperty("headquarters", out var headquarters) && headquarters.ValueKind != JsonValueKind.Null ? headquarters.GetString() : null,
                Homepage = root.TryGetProperty("homepage", out var homepage) && homepage.ValueKind != JsonValueKind.Null ? homepage.GetString() : null,
                LogoPath = root.TryGetProperty("logo_path", out var logoPath) && logoPath.ValueKind != JsonValueKind.Null ? Path.Combine(AppSettings.ImagesPath, "logos", logoPath.GetString().TrimStart('/')) : null,
                ParentCompany = root.TryGetProperty("parent_company", out var parentCompany) && parentCompany.ValueKind != JsonValueKind.Null ? parentCompany.GetProperty("name").GetString() : null,
            };

            return company;
        }

        public static List<MovieCompany> ReadMovieCompanyData(string filePath)
        {
            var json = File.ReadAllText(filePath);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            var movieCompanies = new List<MovieCompany>();
            var movieId = root.GetProperty("id").GetInt32();
            var companies = root.GetProperty("production_companies");
            foreach (var company in companies.EnumerateArray())
            {
                var companyId = company.GetProperty("id").GetInt32();
                movieCompanies.Add(new MovieCompany
                {
                    MovieId = movieId,
                    CompanyId = companyId,
                });
            }

            return movieCompanies;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var companies = new List<Company>();
            var companyDataPath = Path.GetFullPath(Path.Combine(AppSettings.StartupPath, "..\\..\\..\\Data\\data\\company_data"));
            foreach (var file in Directory.EnumerateFiles(companyDataPath, "*.json"))
            {
                companies.Add(ReadCompanyData(file));
            }

            var people = new List<Person>();
            var peopleDataPath = Path.GetFullPath(Path.Combine(AppSettings.StartupPath, "..\\..\\..\\Data\\data\\people_data"));
            foreach (var file in Directory.EnumerateFiles(peopleDataPath, "*.json"))
            {
                people.Add(ReadPersonData(file));
            }

            var movies = new List<Movie>();
            var movieCompanies = new List<MovieCompany>();
            var movieDataPath = Path.GetFullPath(Path.Combine(AppSettings.StartupPath, "..\\..\\..\\Data\\data\\movie_data"));
            foreach (var file in Directory.EnumerateFiles(movieDataPath, "*.json"))
            {
                movies.Add(ReadMovieData(file));
                var newMovieCompanies = ReadMovieCompanyData(file);
                movieCompanies.AddRange(newMovieCompanies);
            }

            var credits = new List<Credit>();
            var creditDataPath = Path.GetFullPath(Path.Combine(AppSettings.StartupPath, "..\\..\\..\\Data\\data\\credit_data"));
            foreach (var file in Directory.EnumerateFiles(creditDataPath, "*.json"))
            {
                credits.Add(ReadCreditData(file));
            }

            modelBuilder.Entity<Company>().HasData(companies);
            modelBuilder.Entity<Person>().HasData(people);
            modelBuilder.Entity<Movie>().HasData(movies);
            modelBuilder.Entity<MovieCompany>().HasData(movieCompanies);
            modelBuilder.Entity<Credit>().HasData(credits);

            modelBuilder.Entity<ListMovie>().HasKey(pt => new { pt.ListId, pt.MovieId });
            modelBuilder.Entity<ListMovie>()
                .HasOne(lm => lm.List)
                .WithMany(l => l.Movies)
                .HasForeignKey(lm => lm.ListId);
            modelBuilder.Entity<ListMovie>()
                .HasOne(lm => lm.Movie)
                .WithMany(m => m.Lists)
                .HasForeignKey(lm => lm.MovieId);

            modelBuilder.Entity<MovieCompany>().HasKey(mc => new { mc.MovieId, mc.CompanyId });
            modelBuilder.Entity<MovieCompany>()
                .HasOne(mc => mc.Company)
                .WithMany(c => c.Movies)
                .HasForeignKey(mc => mc.CompanyId);
            modelBuilder.Entity<MovieCompany>()
                .HasOne(mc => mc.Movie)
                .WithMany(m => m.Companies)
                .HasForeignKey(mc => mc.MovieId);

            modelBuilder.Entity<Credit>().HasKey(c => c.Id);
            modelBuilder.Entity<Credit>()
                .HasOne(c => c.Movie)
                .WithMany(m => m.Credits)
                .HasForeignKey(c => c.MovieId);
            modelBuilder.Entity<Credit>()
                .HasOne(c => c.Person)
                .WithMany(p => p.Credits)
                .HasForeignKey(c => c.PersonId);
        }
    }
}
