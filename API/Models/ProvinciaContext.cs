using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ProvinciaContext : DbContext
    {
        public ProvinciaContext(DbContextOptions<RegionContext> options)
           : base(options)
        {

        }

        public DbSet<Provincia> Provincias { get; set; }
    }
}
