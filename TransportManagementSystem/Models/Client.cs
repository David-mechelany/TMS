using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Client")]
    public partial class Client
    {
        public Client()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(20)]
        public string ClientFname { get; set; }
        [StringLength(20)]
        public string ClientLname { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
        [StringLength(15)]
        public string ClientPhone { get; set; }
        public bool? IsDeleted { get; set; }

        [InverseProperty(nameof(Order.Client))]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
