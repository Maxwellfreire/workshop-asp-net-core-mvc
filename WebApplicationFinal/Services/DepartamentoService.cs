using System.Collections.Generic;
using System.Linq;
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

        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x => x.Name).ToList();

        }

    }
}
