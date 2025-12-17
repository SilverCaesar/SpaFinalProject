using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaFinalProject.Components.Models
{
    public class Appointment
    {
        [Key]
        public int Appointment_Id { get; set; }

    
        public string Customer_Id { get; set; } = string.Empty;

        public Customer ?Customer { get; set; }

        public int Employee_Id { get; set; }
        public Employee ?Employee { get; set; }


        public int Service_Id { get; set; }
        public Service ?Service { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Start { get; set; }

        public string? Status { get; set; }

        public string? Notes { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Duration { get; set; }
    }
}
