using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicamentApp.Models
{
    public class Recipes
    {
        [Key]
        public int RecipeId { get; set; }

        public DateTime DatePrescribed { get; set; }

        [ForeignKey("Drug")]
        public int DrugId { get; set; }
        public Drug Drug { get; set; }

        [StringLength(255)]
        public string DoctorName { get; set; }

        [StringLength(255)]
        public string HospitalAddress { get; set; }
    }
}
