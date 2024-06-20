using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Entities
{
    public enum ListType
    {
        Private,
        Public,
    }

    public class List
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Overview { get; set; }
        public string? PosterPath { get; set; }
        public string? BackdropPath { get; set; }
        [Required]
        public ListType Type { get; set; }
        public string? UserId { get; set; }
        public User? User { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt {  get; set; }
        public ICollection<ListMovie> Movies { get; set; } = new List<ListMovie>();
    }
}
