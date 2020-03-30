using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplicationFinal.Models
{
    public class Vendedor
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Vendedor() { }

        public Vendedor(int id, string name, string email, DateTime birthDate, double baseSalary, Departamento departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departamento = departamento;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {

            Sales.Remove(sr);

        }

        public double TotalSales(DateTime inicial, DateTime final)
        {

            return Sales.Where(sr => sr.Date >= inicial && sr.Date <= final).Sum(sr => sr.Amount);

        }
    }
}
