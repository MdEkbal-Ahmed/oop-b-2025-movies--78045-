using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public string Director { get; set; } = string.Empty;
        public string Cast { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal IMDbRating { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal BoxOfficeRevenue { get; set; }

        public string ReleaseCountry { get; set; } = string.Empty;

        public List<MovieActor> MovieActors { get; set; } = new List<MovieActor>();
    }
}
