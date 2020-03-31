using System.Collections.Generic;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationFinal.Models
{
    public class Departamento
    {

        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }
        public ICollection<Vendedor> Vendedor { get; set; } = new List<Vendedor>();

        public Departamento() { }

        public Departamento(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            Vendedor.Add(vendedor);
        }

        public double TotalSales(DateTime inicial, DateTime final)

        {
            return Vendedor.Sum(Vendedor => Vendedor.TotalSales(inicial, final));
        }
    }
}
