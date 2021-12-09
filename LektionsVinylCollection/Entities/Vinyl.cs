using System;
using System.ComponentModel.DataAnnotations;

namespace LektionsVinylCollection.Entities
{
    public class Vinyl
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Artist { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        public DateTime Created { get; set; }
    }
}
