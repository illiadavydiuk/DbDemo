using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models
{
    public class Resident
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResidentId { get; set; }

        [Required]
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

    //    public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    //    public virtual ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();
    }
}
