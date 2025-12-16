using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaFinalProject.Components.Models
{
    public class Customer : User
    {
        [Key]public string Customer_Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string ?Notes { get; set; }

        public TimeSpan DateAccount { get; }

        public Customer()
        {
        }
    }

}
