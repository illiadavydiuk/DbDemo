using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }

        [Required]
        public string Street { get; set; }
        public string HouseNumber { get; set; }

        [ForeignKey(nameof(District))]
        public int DistrictId { get; set; }
        public virtual District District { get; set; }

        //public virtual ICollection<School> Schools { get; set; } = new HashSet<School>();
        public virtual ICollection<Resident> Residents { get; set; } = new HashSet<Resident>();
    }
}
