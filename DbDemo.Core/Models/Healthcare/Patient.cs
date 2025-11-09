using DbDemo.Core.Models.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Healthcare
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }

        [ForeignKey(nameof(Resident))] public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }

        public string Diagnosis { get; set; }
        public string MedicalHistory { get; set; }

        public virtual ICollection<MedicalVisit> Visits { get; set; } = new HashSet<MedicalVisit>();
    }
}
