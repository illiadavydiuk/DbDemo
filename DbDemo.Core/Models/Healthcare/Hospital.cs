using DbDemo.Core.Models.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace DbDemo.Core.Models.Healthcare
{
    public class Hospital
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HospitalId { get; set; }

        [Required] public string Name { get; set; }
        [Required] public string Type { get; set; }

        [ForeignKey(nameof(Address))] public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; } = new HashSet<Doctor>();
    }
}
