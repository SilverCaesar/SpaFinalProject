using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaFinalProject.Components.Models
{
    public class Service
    {

        [Key] public int Service_Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Duration { get; set; }
    

    public Service(string name, string description, decimal price, int duration)
        {
            Name = name;
            Description = description;
            Price = price;
            Duration = duration;
        }
    }
}