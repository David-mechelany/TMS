using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            OrderByPartners = new HashSet<OrderByPartner>();
            Orders = new HashSet<Order>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(30)]
        public string ProductName { get; set; }
        [StringLength(100)]
        public string ProductDesc { get; set; }
        public bool? IsDeleted { get; set; }

        [InverseProperty(nameof(OrderByPartner.Product))]
        public virtual ICollection<OrderByPartner> OrderByPartners { get; set; }
        [InverseProperty(nameof(Order.Product))]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
