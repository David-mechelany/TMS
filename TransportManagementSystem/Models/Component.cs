using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Component")]
    public partial class Component
    {
        public Component()
        {
            MaintComps = new HashSet<MaintComp>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(30)]
        public string ComponentName { get; set; }
        public string ComponentDesc { get; set; }
        public bool? IsDeleted { get; set; }

        [InverseProperty(nameof(MaintComp.Component))]
        public virtual ICollection<MaintComp> MaintComps { get; set; }
    }
}
