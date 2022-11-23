using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Invoice")]
    public partial class Invoice
    {
        public Invoice()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public int InvoiceNumber { get; set; }
        public int? PartnerId { get; set; }
        public int? GarageId { get; set; }
        public int? StationId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? InvDate { get; set; }
        [Column(TypeName = "money")]
        public decimal? CalculationAmount { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey(nameof(GarageId))]
        [InverseProperty("Invoices")]
        public virtual Garage Garage { get; set; }
        [ForeignKey(nameof(PartnerId))]
        [InverseProperty("Invoices")]
        public virtual Partner Partner { get; set; }
        [ForeignKey(nameof(StationId))]
        [InverseProperty("Invoices")]
        public virtual Station Station { get; set; }
        [InverseProperty(nameof(Order.InvoiceNumberNavigation))]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
