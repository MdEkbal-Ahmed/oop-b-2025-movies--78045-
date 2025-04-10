using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        // New properties added
        public string Director { get; set; } = string.Empty; // Director of the movie

        public string Cast { get; set; } = string.Empty; // Comma-separated list of actors/actresses

        [Column(TypeName = "decimal(18, 2)")]
        public decimal IMDbRating { get; set; } // IMDb Rating

        [Column(TypeName = "decimal(18, 2)")]
        public decimal BoxOfficeRevenue { get; set; } // Box Office Revenue

        public string ReleaseCountry { get; set; } = string.Empty; // Country where the movie was released
    }
}
