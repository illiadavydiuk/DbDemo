using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DbDemo.Core.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }

        [ForeignKey(nameof(Resident))]
        public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }

        public string Discipline { get; set; }
        public int ExperienceYears { get; set; }

        [ForeignKey(nameof(School))]
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
    }
}
