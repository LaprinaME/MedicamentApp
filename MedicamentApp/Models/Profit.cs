using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicamentApp.Models
{
    public class Profit
    {
        [Key]
        public int ProfitId { get; set; }

        [ForeignKey("Drug")]
        public int DrugId { get; set; }
        public Drug Drug { get; set; }

        public DateTime DateReceived { get; set; }

        public int Quantity { get; set; }

        [StringLength(255)]
        public string Supplier { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal PurchasePrice { get; set; }
    }
}
