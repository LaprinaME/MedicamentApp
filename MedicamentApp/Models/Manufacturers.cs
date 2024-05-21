using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MedicamentApp.Models
{
    public class Manufacturers
    {
        [Key]
        public int ManufacturerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public ICollection<Drug> Drugs { get; set; }
    }
}
