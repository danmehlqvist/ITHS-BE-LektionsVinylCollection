using System;

namespace LektionsVinylCollection.Entities
{
    public class Vinyl
    {
        public int Id { get; set; }
        public string Artist { get; set; }
        //public int ArtistID { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
    }
}
