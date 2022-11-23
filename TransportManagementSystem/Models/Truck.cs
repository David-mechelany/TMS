using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Truck")]
    public partial class Truck
    {
        public Truck()
        {
            Fillings = new HashSet<Filling>();
            LocalTransports = new HashSet<LocalTransport>();
            Maintenances = new HashSet<Maintenance>();
        }

        [Key]
        [StringLength(20)]
        public string TruckNumber { get; set; }
        [Column("TruckBrandID")]
        public int? TruckBrandId { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey(nameof(TruckBrandId))]
        [InverseProperty("Trucks")]
        public virtual TruckBrand TruckBrand { get; set; }
        [InverseProperty(nameof(Filling.TruckNumberNavigation))]
        public virtual ICollection<Filling> Fillings { get; set; }
        [InverseProperty(nameof(LocalTransport.TruckNumberNavigation))]
        public virtual ICollection<LocalTransport> LocalTransports { get; set; }
        [InverseProperty(nameof(Maintenance.TruckNumberNavigation))]
        public virtual ICollection<Maintenance> Maintenances { get; set; }
    }
}
