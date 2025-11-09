using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DbDemo.Core.Models.Common;

namespace DbDemo.Core.Models.Education
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }

        [ForeignKey(nameof(Resident))] public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }

        [ForeignKey(nameof(School))] public int SchoolId { get; set; }
        public virtual School School { get; set; }

        public int ExperienceYears { get; set; }

        public virtual ICollection<Class> Classes { get; set; } = new HashSet<Class>();
    }
}
