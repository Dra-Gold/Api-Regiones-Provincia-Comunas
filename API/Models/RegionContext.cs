using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class RegionContext : DbContext
    {
        public RegionContext(DbContextOptions<RegionContext>options)
            :base(options)
        {

        }

        public DbSet<Region> Regiones { get; set; }
    }
}
