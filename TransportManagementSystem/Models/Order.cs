using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Order")]
    public partial class Order
    {
        public Order()
        {
            LocalTransports = new HashSet<LocalTransport>();
            PartnerTransports = new HashSet<PartnerTransport>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("ClientID")]
        public int? ClientId { get; set; }
        public int? InvoiceNumber { get; set; }
        [Column(TypeName = "date")]
        public DateTime? OrderDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpectedDate { get; set; }
        public int? LocationId { get; set; }
        public int? ProductId { get; set; }
        [StringLength(50)]
        public string Reference { get; set; }
        [StringLength(15)]
        public string ReferencePhone { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey(nameof(ClientId))]
        [InverseProperty("Orders")]
        public virtual Client Client { get; set; }
        [ForeignKey(nameof(InvoiceNumber))]
        [InverseProperty(nameof(Invoice.Orders))]
        public virtual Invoice InvoiceNumberNavigation { get; set; }
        [ForeignKey(nameof(LocationId))]
        [InverseProperty("Orders")]
        public virtual Location Location { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("Orders")]
        public virtual Product Product { get; set; }
        [InverseProperty(nameof(LocalTransport.Order))]
        public virtual ICollection<LocalTransport> LocalTransports { get; set; }
        [InverseProperty(nameof(PartnerTransport.Order))]
        public virtual ICollection<PartnerTransport> PartnerTransports { get; set; }
    }
}
