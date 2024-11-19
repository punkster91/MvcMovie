using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        /// <summary>
        /// Primary key in the database
        /// </summary>
        public int Id { get; set; }
        public string? Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public ICollection<Genre>? Genres { get; set; }

        public string? Rating { get; set; }

        public int Duration { get; set; }

        public string? Description { get; set; }

        public int? CountryId { get; set; }
        public Country? Country { get; set; }

        /// <summary>
        /// Navigation property to related Media entity
        /// </summary>
        public Media? Media { get; set; }
    }
}
