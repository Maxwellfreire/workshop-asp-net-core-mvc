using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WebApplicationFinal.Models
{
    public class Vendedor
    {

        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} obrigatório!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O tamanho do nome deve estar entre {2} e {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} obrigatório!")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} obrigatório!")]
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
        
        [Required(ErrorMessage = "{0} obrigatório!")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Salário base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
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
