using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public virtual ICollection<Education.Student> Students { get; set; } = new HashSet<Education.Student>();
        public virtual ICollection<Education.Teacher> Teachers { get; set; } = new HashSet<Education.Teacher>();

        // Healthcare
        public virtual ICollection<Healthcare.Doctor> Doctors { get; set; } = new HashSet<Healthcare.Doctor>();
        public virtual ICollection<Healthcare.Patient> Patients { get; set; } = new HashSet<Healthcare.Patient>();
        public virtual ICollection<Healthcare.MedicalReception> MedicalReceptions { get; set; } = new HashSet<Healthcare.MedicalReception>();

        // Economy
        public virtual ICollection<Economy.Employee> Employees { get; set; } = new HashSet<Economy.Employee>();

        // Housing
        public virtual ICollection<Housing.ResidentApartment> ResidentApartments { get; set; } = new HashSet<Housing.ResidentApartment>();

        // Transport
        public virtual ICollection<Transport.Driver> Drivers { get; set; } = new HashSet<Transport.Driver>();
        public virtual ICollection<Transport.Passenger> Passengers { get; set; } = new HashSet<Transport.Passenger>();
    }
}
