using System;
using System.Collections.Generic;
using System.Linq;
using PlatformServices.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreatPlatform(Platform plat)
        {
            if (plat == null)
            {
                throw new ArgumentNullException("plat");
            }
            _context.Platsforms.Add(plat);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platsforms.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            return _context.Platsforms.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}