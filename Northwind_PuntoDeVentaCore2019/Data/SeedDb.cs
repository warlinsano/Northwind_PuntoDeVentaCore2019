using Northwind_PuntoDeVentaCore2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind_PuntoDeVentaCore2019.Data
{
    public class SeedDb
    {
        public readonly NorthwindContext _context;
        public SeedDb(NorthwindContext context)
        {
            _context = context;
        }

        public async Task SeedDbAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await checkRegionAsync();
        }

        private  async Task checkRegionAsync()
        {
            if (!_context.Region.Any())
            {
                _context.Region.Add(new Region { RegionDescription = "Rep. Dom" });
                _context.Region.Add(new Region { RegionDescription = "Rep. Dom" });
                await _context.SaveChangesAsync();                    
            }
        }

    }


}
