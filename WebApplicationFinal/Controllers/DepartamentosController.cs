using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationFinal.Models;

namespace WebApplicationFinal.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {

            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento {Id = 1,Name = "MaxwellStore" });
            list.Add(new Departamento { Id = 2, Name = "ThalytaStore" });

            return View(list);
        }
    }
}