using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("TruckType")]
    public partial class TruckType
    {
        public TruckType()
        {
            TruckBrands = new HashSet<TruckBrand>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("TruckType")]
        [StringLength(20)]
        public string TruckType1 { get; set; }
        public bool? IsDeleted { get; set; }

        [InverseProperty(nameof(TruckBrand.TruckType))]
        public virtual ICollection<TruckBrand> TruckBrands { get; set; }
    }
}
