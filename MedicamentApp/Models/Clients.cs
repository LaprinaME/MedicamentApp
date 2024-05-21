using System;
using System.ComponentModel.DataAnnotations;

namespace MedicamentApp.Models
{
    public class Clients
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(20)]
        public string SNILS { get; set; }

        [StringLength(20)]
        public string Policy { get; set; }
    }
}
