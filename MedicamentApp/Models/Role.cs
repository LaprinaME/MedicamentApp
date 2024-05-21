using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MedicamentApp.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Users> Users { get; set; }
        public ICollection<Employees> Employees { get; set; }
    }
}
