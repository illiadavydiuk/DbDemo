using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Healthcare
{
    public class MedicalVisit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MedicalVisitId { get; set; }

        public DateTime VisitDate { get; set; }
        public string Annotation { get; set; }

        [ForeignKey(nameof(Patient))] public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [ForeignKey(nameof(Doctor))] public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
