using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Common
{
    public class District
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DistrictId { get; set; }

        [Required] public string Name { get; set; }

        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
    }
}
