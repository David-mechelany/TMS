using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("LocalTransport")]
    public partial class LocalTransport
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("OrderID")]
        public int? OrderId { get; set; }
        public int? OrderByPartnerId { get; set; }
        [Column("EmpID")]
        public int? EmpId { get; set; }
        [StringLength(20)]
        public string TruckNumber { get; set; }
        [StringLength(50)]
        public string ContainerNumber { get; set; }
        [Column(TypeName = "date")]
        public DateTime? TransDate { get; set; }
        [StringLength(10)]
        public string TransType { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Done { get; set; }

        [ForeignKey(nameof(EmpId))]
        [InverseProperty(nameof(Employee.LocalTransports))]
        public virtual Employee Emp { get; set; }
        [ForeignKey(nameof(OrderId))]
        [InverseProperty("LocalTransports")]
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(OrderByPartnerId))]
        [InverseProperty("LocalTransports")]
        public virtual OrderByPartner OrderByPartner { get; set; }
        [ForeignKey(nameof(TruckNumber))]
        [InverseProperty(nameof(Truck.LocalTransports))]
        public virtual Truck TruckNumberNavigation { get; set; }
    }
}
