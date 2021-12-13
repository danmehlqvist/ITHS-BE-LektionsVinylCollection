using LektionsVinylCollection.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LektionsVinylCollection.DTOs
{
    public class BasicArtistDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public static class BasicArtistDTOs
    {
        public static BasicArtistDTO MapToBasicArtistDTO(this Artist artist)
        {
            return new BasicArtistDTO
            {
                ID = artist.Id,
                Name = artist.Name,
            };
        }

        public static List<BasicArtistDTO> MapToBasicArtistDTOs(this List<Artist> artists)
        {
            return artists.Select(a => a.MapToBasicArtistDTO()).ToList();
        }

    }
}
