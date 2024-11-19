using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Movie>? Movies { get; set; }
    }
}
