using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Filling")]
    public partial class Filling
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(20)]
        public string TruckNumber { get; set; }
        [Column("StationID")]
        public int? StationId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FillingDate { get; set; }
        public int? FillVolume { get; set; }
        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey(nameof(StationId))]
        [InverseProperty("Fillings")]
        public virtual Station Station { get; set; }
        [ForeignKey(nameof(TruckNumber))]
        [InverseProperty(nameof(Truck.Fillings))]
        public virtual Truck TruckNumberNavigation { get; set; }
    }
}
