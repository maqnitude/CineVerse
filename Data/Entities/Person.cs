using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Entities
{
    public enum Gender
    {
        NotSpecified = 0,
        Female = 1,
        Male = 2,
        NonBinary = 3,
    }

    public class Person
    {
        // TMDB id
        public int Id { get; set; }
        public string? ImdbId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<string> OtherNames { get; set; } = new List<string>();
        public string? Biography { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public string? ProfilePath { get; set; }
        public string? PlaceOfBirth { get; set; }
        public DateTime? BirthDay { get; set; }
        public DateTime? DeathDay { get; set; }
        public double? Popularity { get; set; }
        [Required]
        public string MainExpertise { get; set; }
        public string? Homepage { get; set; }
        public ICollection<Credit> Credits { get; set; } = new List<Credit>();
    }
}
