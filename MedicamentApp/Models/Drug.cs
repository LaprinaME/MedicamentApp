using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicamentApp.Models
{
    public class Drug
    {
        [Key]
        public int DrugId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [ForeignKey("Manufacturer")]
        public int ManufacturerId { get; set; }
        public Manufacturers Manufacturers { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(255)]
        public string StorageLocation { get; set; }

        public ICollection<Profit> Profits { get; set; }
        public ICollection<Expenses> Expenses { get; set; }
        public ICollection<Recipes> Recipes { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
