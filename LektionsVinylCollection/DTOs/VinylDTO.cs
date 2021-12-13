using LektionsVinylCollection.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LektionsVinylCollection.DTOs
{
    public class VinylDTO
    {
        public int Id { get; set; }
        public BasicArtistDTO Artist { get; set; }
        public string Title { get; set; }
    }

    public static class VinylDtoExtensions
    {
        public static VinylDTO MapToVinylDTO(this Vinyl vinyl)
        {
            return new VinylDTO
            {
                Id = vinyl.Id,
                Artist = vinyl.Artist.MapToBasicArtistDTO(),
                Title = vinyl.Title,
            };
        }

        public static List<VinylDTO> MapToVinylDTOs(this List<Vinyl> vinyls)
        {
            return vinyls.Select(v => v.MapToVinylDTO()).ToList();
        }




    }
}

