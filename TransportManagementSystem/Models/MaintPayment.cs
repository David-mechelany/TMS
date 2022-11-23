using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("MaintPayment")]
    public partial class MaintPayment
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("MID")]
        public int? Mid { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PaymentDate { get; set; }
        [Column(TypeName = "money")]
        public decimal? PaymentAmount { get; set; }

        [ForeignKey(nameof(Mid))]
        [InverseProperty(nameof(Maintenance.MaintPayments))]
        public virtual Maintenance MidNavigation { get; set; }
    }
}
