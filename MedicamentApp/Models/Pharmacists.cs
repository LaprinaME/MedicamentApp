using System;
using System.ComponentModel.DataAnnotations;

namespace MedicamentApp.Models
{
    public class Pharmacists
    {
        [Key]
        public int PharmacistId { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        public DateTime HireDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
