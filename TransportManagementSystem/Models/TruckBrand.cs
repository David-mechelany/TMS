using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("TruckBrand")]
    public partial class TruckBrand
    {
        public TruckBrand()
        {
            Trucks = new HashSet<Truck>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("TruckBrand")]
        [StringLength(20)]
        public string TruckBrand1 { get; set; }
        public int? TruckTypeId { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey(nameof(TruckTypeId))]
        [InverseProperty("TruckBrands")]
        public virtual TruckType TruckType { get; set; }
        [InverseProperty(nameof(Truck.TruckBrand))]
        public virtual ICollection<Truck> Trucks { get; set; }
    }
}
