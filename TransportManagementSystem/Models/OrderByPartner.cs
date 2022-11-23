using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("OrderByPartner")]
    public partial class OrderByPartner
    {
        public OrderByPartner()
        {
            LocalTransports = new HashSet<LocalTransport>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int? PartnerId { get; set; }
        public int? InvoiceNumber { get; set; }
        [Column(TypeName = "date")]
        public DateTime? OrderDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpectedDate { get; set; }
        public int? LocationId { get; set; }
        public int? ProductId { get; set; }
        [StringLength(50)]
        public string ReferenceFn { get; set; }
        [StringLength(15)]
        public string ReferencePhone { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey(nameof(LocationId))]
        [InverseProperty("OrderByPartners")]
        public virtual Location Location { get; set; }
        [ForeignKey(nameof(PartnerId))]
        [InverseProperty("OrderByPartners")]
        public virtual Partner Partner { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("OrderByPartners")]
        public virtual Product Product { get; set; }
        [InverseProperty(nameof(LocalTransport.OrderByPartner))]
        public virtual ICollection<LocalTransport> LocalTransports { get; set; }
    }
}
