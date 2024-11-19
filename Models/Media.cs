namespace MvcMovie.Models
{
    public class Media
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Foreign key to related Movie entity
        /// </summary>
        public int MovieId { get; set; }

        /// <summary>
        /// EF Navigation property to related Movie entity
        /// </summary>
        public Movie Movie { get; set; }

        public string BaseImagePath { get; set; }
        public string ThumbnailPath { get; set; }
    }
}
