using System;
using System.ComponentModel.DataAnnotations;
using WebApplicationFinal.Models.Enums;

namespace WebApplicationFinal.Models
{
    public class SalesRecord
    {

        public int Id { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Display(Name = "Montante")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Vendedor vendedor)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Vendedor = vendedor;
        }


    }
}
