using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Garage")]
    public partial class Garage
    {
        public Garage()
        {
            Invoices = new HashSet<Invoice>();
            Maintenances = new HashSet<Maintenance>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(20)]
        public string GarageName { get; set; }
        public bool? IsDeleted { get; set; }

        [InverseProperty(nameof(Invoice.Garage))]
        public virtual ICollection<Invoice> Invoices { get; set; }
        [InverseProperty(nameof(Maintenance.Garage))]
        public virtual ICollection<Maintenance> Maintenances { get; set; }
    }
}
