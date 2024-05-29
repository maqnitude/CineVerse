using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Models
{
    public class MovieCompany
    {
        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
