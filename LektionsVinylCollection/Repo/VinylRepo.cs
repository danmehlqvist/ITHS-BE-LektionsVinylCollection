using LektionsVinylCollection.DTOs;
using LektionsVinylCollection.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LektionsVinylCollection.Repo
{
    public class VinylRepo : IVinylRepo
    {
        private ApplicationContext _context;
        //private ApplicationContext _db;

        public VinylRepo(ApplicationContext context)
        {
            _context = context;
        }

        public Vinyl CreateVinyl(CreateVinylDTO createdVinylDTO)
        {
            Vinyl vinyl = new Vinyl();

            vinyl.Created = DateTime.Now;
            vinyl.Artist = createdVinylDTO.Artist;
            vinyl.Title = createdVinylDTO.Title;

            _context.Vinyls.Add(vinyl);
            _context.SaveChanges();

            return vinyl;
        }

        public void DeleteVinyl(int id)
        {
            _context.Vinyls.Remove(GetByID(id));
            _context.SaveChanges();
        }

        public List<Vinyl> GetAll()
        {
            return _context.Vinyls.ToList();
        }

        public Vinyl GetByID(int id)
        {
            //Vinyl vinyl = _vinyls.Find(x => x.Id == id);
            Vinyl vinyl = _context.Vinyls.Find(id);
            return vinyl;
        }

        public Vinyl UpdateVinyl(Vinyl vinyl,int id)
        {
            Vinyl existingVinyl = _context.Vinyls.FirstOrDefault(x => x.Id == id);
            if (existingVinyl is not null)
            {
                existingVinyl.Title = vinyl.Title;
                existingVinyl.Artist = vinyl.Artist;
            }
            // Kan i äldre versioner krävas att vi manuellt ställer
            // statusen på vinyl till Changed.
            _context.SaveChanges();
            return existingVinyl;
        }

    }
}
