using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Location")]
    public partial class Location
    {
        public Location()
        {
            OrderByPartners = new HashSet<OrderByPartner>();
            Orders = new HashSet<Order>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("Location")]
        [StringLength(250)]
        public string Location1 { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        public bool? IsDeleted { get; set; }

        [InverseProperty(nameof(OrderByPartner.Location))]
        public virtual ICollection<OrderByPartner> OrderByPartners { get; set; }
        [InverseProperty(nameof(Order.Location))]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
