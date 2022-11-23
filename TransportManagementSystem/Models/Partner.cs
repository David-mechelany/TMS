using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Partner")]
    public partial class Partner
    {
        public Partner()
        {
            Invoices = new HashSet<Invoice>();
            OrderByPartners = new HashSet<OrderByPartner>();
            PartnerTransports = new HashSet<PartnerTransport>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(20)]
        public string PartnerFname { get; set; }
        [StringLength(20)]
        public string PartnerLname { get; set; }
        [StringLength(15)]
        public string PartnerPhone { get; set; }
        public bool? IsDeleted { get; set; }

        [InverseProperty(nameof(Invoice.Partner))]
        public virtual ICollection<Invoice> Invoices { get; set; }
        [InverseProperty(nameof(OrderByPartner.Partner))]
        public virtual ICollection<OrderByPartner> OrderByPartners { get; set; }
        [InverseProperty(nameof(PartnerTransport.Partner))]
        public virtual ICollection<PartnerTransport> PartnerTransports { get; set; }
    }
}
