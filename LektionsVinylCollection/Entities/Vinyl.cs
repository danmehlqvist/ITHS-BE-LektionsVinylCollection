using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LektionsVinylCollection.Entities
{
    public class Vinyl
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Artist")]
        public int ArtistID { get; set; }

        public Artist Artist { get; set; }

        //[Required]
        //public string Artist { get; set; }

        [Required]
        public string Title { get; set; }
        
        public DateTime Created { get; set; }
    }
}
