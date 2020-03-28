using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationFinal.Models
{
    public class WebApplicationFinalContext : DbContext
    {
        public WebApplicationFinalContext (DbContextOptions<WebApplicationFinalContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
