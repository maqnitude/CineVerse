using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Models
{
    public class Credit
    {
        // TMDB id
        public string Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [Required]
        public int PersonId { get; set; }
        public Person Person { get; set; }
        [Required]
        public string Department { get; set; }
        public string? Job { get; set; }
        public string? Character { get; set; }
        public int? Order { get; set; }
    }
}
