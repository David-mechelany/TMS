using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("PartnerTransport")]
    public partial class PartnerTransport
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? PartnerId { get; set; }
        [StringLength(50)]
        public string ContainerNumber { get; set; }
        [Column(TypeName = "date")]
        public DateTime? TransDate { get; set; }
        [StringLength(10)]
        public string TransType { get; set; }
        public int? ProductId { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Done { get; set; }

        [ForeignKey(nameof(OrderId))]
        [InverseProperty("PartnerTransports")]
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(PartnerId))]
        [InverseProperty("PartnerTransports")]
        public virtual Partner Partner { get; set; }
    }
}
