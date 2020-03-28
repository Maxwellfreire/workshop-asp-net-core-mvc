using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFinal.Models;

namespace WebApplicationFinal.Services
{
    public class VendedorService
    {

        private readonly WebApplicationFinalContext _context;

        public VendedorService(WebApplicationFinalContext context)
        {
            _context = context;

        }

        public List<Vendedor> FindAll()
        {

            return _context.Vendedor.ToList();

        }

        public void Insert(Vendedor obj)

        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
