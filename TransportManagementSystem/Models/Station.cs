using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Station")]
    public partial class Station
    {
        public Station()
        {
            Fillings = new HashSet<Filling>();
            Invoices = new HashSet<Invoice>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(20)]
        public string StationName { get; set; }
        [StringLength(50)]
        public string StationAddress { get; set; }
        public bool? IsDeleted { get; set; }

        [InverseProperty(nameof(Filling.Station))]
        public virtual ICollection<Filling> Fillings { get; set; }
        [InverseProperty(nameof(Invoice.Station))]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
