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

        public string email
        {
            get => Email;
            set => Email = value;
        }

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
            Email = email ?? string.Empty;
            this.password = password ?? string.Empty;
            this.phone = phone ?? string.Empty;
        }
    }
}

