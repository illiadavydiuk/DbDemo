using DbDemo.Core.Models.Economy;
using DbDemo.Core.Models.Education;
using DbDemo.Core.Models.Healthcare;
using DbDemo.Core.Models.Transport;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace DbDemo.Core.Models.Common
{
    public class Resident
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResidentId { get; set; }

        [Required] public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [ForeignKey(nameof(Address))] public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        // Education
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public virtual ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();

        // Healthcare
        public virtual ICollection<Doctor> Doctors { get; set; } = new HashSet<Doctor>();
        public virtual ICollection<Patient> Patients { get; set; } = new HashSet<Patient>();

        // Transport
        public virtual ICollection<Driver> Drivers { get; set; } = new HashSet<Driver>();

        // Economy
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
