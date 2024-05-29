using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Country { get; set; }
        public string? Description { get; set; }
        public string? Headquarters { get; set; }
        public string? Homepage { get; set; }
        public string? LogoPath { get; set; }
        public string? ParentCompany { get; set; }
        public ICollection<MovieCompany> Movies { get; set; } = new List<MovieCompany>();
    }
}
