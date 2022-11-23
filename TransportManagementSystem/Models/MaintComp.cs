using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("MaintComp")]
    public partial class MaintComp
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Key]
        [Column("ComponentID")]
        public int ComponentId { get; set; }
        [Column(TypeName = "money")]
        public decimal? MainCompPrice { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey(nameof(ComponentId))]
        [InverseProperty("MaintComps")]
        public virtual Component Component { get; set; }
        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(Maintenance.MaintComps))]
        public virtual Maintenance IdNavigation { get; set; }
    }
}
