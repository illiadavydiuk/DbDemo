using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DbDemo.Core.Models.Common;

namespace DbDemo.Core.Models.Education
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        [ForeignKey(nameof(Resident))] public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }

        [ForeignKey(nameof(Class))] public int ClassId { get; set; }
        public virtual Class Class { get; set; }
    }
}
