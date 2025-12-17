using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaFinalProject.Components.Models
{
    public class Employee : User
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string ?EmployeeType { get; set; }
        public Service ?Specialization { get; set; }
    }
}
