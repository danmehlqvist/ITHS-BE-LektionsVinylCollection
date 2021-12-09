using System.ComponentModel.DataAnnotations;

namespace LektionsVinylCollection.Entities
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FavoriteCar { get; set; }

        [Required]
        public DataType Created { get; set; }
    }
}
