using LektionsVinylCollection.DTOs;
using LektionsVinylCollection.Entities;
using System;
using System.Collections.Generic;

namespace LektionsVinylCollection.Repo
{
    public interface IVinylRepo
    {
        List<Vinyl> GetAll();

        Vinyl GetByID(int id);

        Vinyl CreateVinyl(CreateVinylDTO vinyl);

        Vinyl UpdateVinyl(Vinyl vinyl);

        void DeleteVinyl(int id);
    }
}
