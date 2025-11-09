using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Common
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }

        [Required] public string Street { get; set; }
        [Required] public string HouseNumber { get; set; }

        [ForeignKey(nameof(District))] public int DistrictId { get; set; }
        public virtual District District { get; set; }

        // двосторонні зв’язки
        public virtual ICollection<Resident> Residents { get; set; } = new HashSet<Resident>();
        public virtual ICollection<Education.School> Schools { get; set; } = new HashSet<Education.School>();
        public virtual ICollection<Healthcare.Hospital> Hospitals { get; set; } = new HashSet<Healthcare.Hospital>();
        public virtual ICollection<Transport.Stop> Stops { get; set; } = new HashSet<Transport.Stop>();
        public virtual ICollection<Housing.Building> Buildings { get; set; } = new HashSet<Housing.Building>();
        public virtual ICollection<Economy.Company> Companies { get; set; } = new HashSet<Economy.Company>();
    }
}
