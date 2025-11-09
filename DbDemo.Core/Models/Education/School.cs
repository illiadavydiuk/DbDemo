using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DbDemo.Core.Models.Common;

namespace DbDemo.Core.Models.Education
{
    public class School
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SchoolId { get; set; }

        [Required] public string SchoolName { get; set; }
        [Required] public string Director { get; set; }

        [ForeignKey(nameof(Address))] public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<Class> Classes { get; set; } = new HashSet<Class>();
        public virtual ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
