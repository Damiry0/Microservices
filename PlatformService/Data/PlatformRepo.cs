using System.Collections.Generic;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _conext;

        public PlatformRepo(AppDbContext context)
        {
            _conext = context;
        }

        public void CreatePlatform(Platform plat)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            throw new System.NotImplementedException();
        }

        public Platform GetPlatformById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}