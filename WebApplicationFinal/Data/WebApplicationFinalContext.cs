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

        public DbSet<WebApplicationFinal.Models.Departamento> Departamento { get; set; }
    }
}
