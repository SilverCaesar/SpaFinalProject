using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaFinalProject.Components.Models
{
    public class Customer : User
    {
        [Key] public string Customer_Id { get; set; } = string.Empty;
        public string Fname { get; set; } = string.Empty;
        public string Lname { get; set; } = string.Empty;
        public string? Notes { get; set; }

        public TimeSpan DateAccount { get; set; } = TimeSpan.Zero;

        // Optional FK / mapping to a User entity
        public string User_Id { get; set; } = string.Empty;

        // Common properties used by views. Keep PascalCase versions plus lowercase aliases
        // so existing Razor markup that references `customer.email` / `customer.password` / `customer.phone`
        // continues to compile without changing view code.
        [NotMapped]
        public string email
        {
            get => Email;
            set => Email = value;
        }

        [Required]
        public string Email { get; set; } = string.Empty;

        [NotMapped]
        public string password { get; set; } = string.Empty;

        [NotMapped]
        public string phone { get; set; } = string.Empty;

        public Customer()
        {
        }

        public Customer(string customerId, string fname, string lname, string? notes, TimeSpan dateAccount, string userId = "", string email = "", string password = "", string phone = "")
        {
            Customer_Id = customerId ?? string.Empty;
            Fname = fname ?? string.Empty;
            Lname = lname ?? string.Empty;
            Notes = notes;
            DateAccount = dateAccount;
            User_Id = userId ?? string.Empty;
            Email = email ?? string.Empty;
            this.password = password ?? string.Empty;
            this.phone = phone ?? string.Empty;
        }
    }
}
}
