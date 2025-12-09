using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaFinalProject.Components.Models
{
    public abstract class User
    {
        public int User_Id { get; set; }

        public required string email { get; set; }
        public required string password { get; set; }

        public string ?phone { get; set; }
    }
}
