using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ComunaContext : DbContext
    {
        public ComunaContext(DbContextOptions<ComunaContext> options)
                : base(options)
        {

        }

        public DbSet<Comuna> Comunas { get; set; }
    }
}
