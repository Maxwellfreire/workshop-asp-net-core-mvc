using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationFinal.Models;

namespace WebApplicationFinal.Services
{
    public class DepartamentoService
    {

        private readonly WebApplicationFinalContext _context;

        public DepartamentoService(WebApplicationFinalContext context)
        {
            _context = context;

        }

        public async Task<List<Departamento>> FindAllAsync()
        {
            return await _context.Departamento.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
