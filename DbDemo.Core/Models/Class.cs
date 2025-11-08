using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassId { get; set; }

        [Required]
        public string ClassName { get; set; }

        [ForeignKey(nameof(School))]
        public int SchoolId { get; set; }
        public virtual School School { get; set; }

        //[ForeignKey(nameof(Teacher))]
        public int? TeacherId { get; set; }
        //public virtual Teacher Teacher { get; set; }

        //public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
