using DbDemo.Core.Models.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Healthcare
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }

        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public string Specialty { get; set; }

        [ForeignKey(nameof(Hospital))] public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }

        [ForeignKey(nameof(Resident))] public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }

        public virtual ICollection<MedicalVisit> Visits { get; set; } = new HashSet<MedicalVisit>();
    }
}
