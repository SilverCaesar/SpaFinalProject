using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaFinalProject.Components.Models
{
    public class Appointment
    {
        [Key]
        public int Appointment_Id { get; set; }

        [Required]
        public string Customer_Id { get; set; } = string.Empty;

        [Required]
        public int Employee_Id { get; set; }

        [Required]
        public int Service_Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime Start { get; set; }

        public string? Status { get; set; }

        public string? Notes { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Duration { get; set; }

        public Appointment()
        {
        }

        public Appointment(
            string customerId,
            int employeeId,
            int serviceId,
            DateTime date,
            DateTime start,
            decimal price = 0m,
            int duration = 0,
            string? status = null,
            string? notes = null)
        {
            Customer_Id = customerId ?? string.Empty;
            Employee_Id = employeeId;
            Service_Id = serviceId;
            Date = date;
            Start = start;
            Price = price;
            Duration = duration;
            Status = status;
            Notes = notes;
        }
    }
}
