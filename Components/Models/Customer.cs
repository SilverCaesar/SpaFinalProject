using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaFinalProject.Components.Models
{
    public class Customer : User
    {
        [Key]public required string Customer_Id { get; set; }
        public required string Fname { get; set; }
        public required string Lname { get; set; }
        public string ?Notes { get; set; }

        public TimeSpan DateAccount { get; }

        public Customer()
        {
        }
    }

}
