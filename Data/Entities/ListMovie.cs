using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Entities
{
    public class ListMovie
    {
        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [Required]
        public string ListId { get; set; }
        public List List { get; set; }
        public string? AuthorId { get; set; }
        public User? Author { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.UtcNow;
    }
}
