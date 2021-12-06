using LektionsVinylCollection.DTOs;
using LektionsVinylCollection.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LektionsVinylCollection.Repo
{
    public class VinylRepo : IVinylRepo
    {
        private List<Vinyl> _vinyls;

        public VinylRepo()
        {
            _vinyls = PopulateVinylData();
        }

        public Vinyl CreateVinyl(CreateVinylDTO createdVinylDTO)
        {
            Vinyl vinyl = new Vinyl();

            vinyl.Created = DateTime.Now;
            vinyl.Id = _vinyls.Max(x => x.Id) + 1;

            _vinyls.Add(vinyl);

            return vinyl;
        }

        public void DeleteVinyl(int id)
        {
            _vinyls.Remove(GetByID(id));
        }

        public List<Vinyl> GetAll()
        {
            return _vinyls;
        }

        public Vinyl GetByID(int id)
        {
            Vinyl vinyl = _vinyls.Find(x => x.Id == id);
            return vinyl;
        }

        public Vinyl UpdateVinyl(Vinyl vinyl)
        {
            Vinyl existingVinyl = _vinyls.FirstOrDefault(x => x.Id == vinyl.Id);
            if (existingVinyl is not null)
            {
                existingVinyl.Title = vinyl.Title;
                existingVinyl.Artist = vinyl.Artist;
            }
            return existingVinyl;
        }

        private List<Vinyl> PopulateVinylData()
        {
            return new List<Vinyl>
            {
                new Vinyl
                {
                    Id = 1,
                    Artist="Guns'n'Roses",
                    //Artist = Guid.NewGuid().ToString(),
                    Title="Appetite for destruction",
                    Created = DateTime.Now,
                },
                new Vinyl
                {
                    Id = 2,
                    Artist="Misfits",
                    Title="Spinal Remains",
                    Created = DateTime.Now,
                },
                new Vinyl
                {
                    Id = 3,
                    Artist="ABBA",
                    Title="Best of",
                    Created = DateTime.Now,
                },
                new Vinyl
                {
                    Id = 4,
                    Artist="Kraftklub",
                    Title="Mit K",
                    Created = DateTime.Now,
                },
                new Vinyl
                {
                    Id = 5,
                    Artist="Lard",
                    Title="Power of Lard",
                    Created = DateTime.Now,
                },
            };
        }
    }
}
