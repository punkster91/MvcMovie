using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
