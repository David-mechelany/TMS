using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Maintenance")]
    public partial class Maintenance
    {
        public Maintenance()
        {
            MaintComps = new HashSet<MaintComp>();
            MaintPayments = new HashSet<MaintPayment>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(20)]
        public string TruckNumber { get; set; }
        [Column("GarageID")]
        public int? GarageId { get; set; }
        [Column("MDate", TypeName = "date")]
        public DateTime? Mdate { get; set; }
        [Column("MTotalAmount", TypeName = "money")]
        public decimal? MtotalAmount { get; set; }
        [StringLength(50)]
        public string Details { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey(nameof(GarageId))]
        [InverseProperty("Maintenances")]
        public virtual Garage Garage { get; set; }
        [ForeignKey(nameof(TruckNumber))]
        [InverseProperty(nameof(Truck.Maintenances))]
        public virtual Truck TruckNumberNavigation { get; set; }
        [InverseProperty(nameof(MaintComp.IdNavigation))]
        public virtual ICollection<MaintComp> MaintComps { get; set; }
        [InverseProperty(nameof(MaintPayment.MidNavigation))]
        public virtual ICollection<MaintPayment> MaintPayments { get; set; }
    }
}
