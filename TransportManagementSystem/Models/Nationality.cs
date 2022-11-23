using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TransportManagementSystem.Models
{
    [Table("Nationality")]
    public partial class Nationality
    {
        public Nationality()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(2)]
        public string NationalityCode { get; set; }
        [StringLength(30)]
        public string NationalityDesc { get; set; }
        public bool? IsDeleted { get; set; }

        [InverseProperty(nameof(Employee.Nationality))]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
