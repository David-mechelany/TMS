using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Employee")]
    public partial class Employee
    {
        public Employee()
        {
            LocalTransports = new HashSet<LocalTransport>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(450)]
        public string UserId { get; set; }
        [StringLength(20)]
        public string EmpFname { get; set; }
        [StringLength(20)]
        public string EmpLname { get; set; }
        [Column("NationalityID")]
        public int? NationalityId { get; set; }
        [StringLength(15)]
        public string EmpPhone { get; set; }
        [Column(TypeName = "money")]
        public decimal? Salary { get; set; }
        public bool? Paid { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateHired { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        [ForeignKey(nameof(NationalityId))]
        [InverseProperty("Employees")]
        public virtual Nationality Nationality { get; set; }
        [InverseProperty(nameof(LocalTransport.Emp))]
        public virtual ICollection<LocalTransport> LocalTransports { get; set; }
    }
}
