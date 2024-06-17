using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Entities
{
    public class Movie
    {
        // TMDB id
        public int Id { get; set; }
        public string ImdbId { get; set; }
        [Required]
        public string Title { get; set; }
        public string? OriginalTitle { get; set; }
        [Required]
        public string Overview { get; set; }
        public double? Popularity { get; set; }
        public List<string> Genres { get; set; } = new List<string>();
        [Required]
        public string BackdropPath { get; set; }
        [Required]
        public string PosterPath { get; set; }
        public long? Budget { get; set; }
        public long? Revenue { get; set; }
        [Required]
        public int Runtime { get; set; }
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public List<string> OriginCountries { get; set; } = new List<string>();
        public List<string> ProductionCountries { get; set; } = new List<string>();
        public string OriginalLanguage { get; set; }
        public List<string> SpokenLanguages { get; set; } = new List<string>();
        public string Status { get; set; }
        public string TagLine { get; set; }
        public string Homepage { get; set; }
        public int? VoteCount { get; set; }
        public double? VoteAverage { get; set; }
        public ICollection<Credit> Credits { get; set; } = new List<Credit>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<ListMovie> Lists { get; set; } = new List<ListMovie>();
        public ICollection<MovieCompany> Companies { get; set; } = new List<MovieCompany>();
    }
}
