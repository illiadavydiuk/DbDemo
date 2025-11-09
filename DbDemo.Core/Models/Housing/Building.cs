using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DbDemo.Core.Models.Common;

namespace DbDemo.Core.Models.Housing
{
    public class Building
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BuildingId { get; set; }

        [ForeignKey(nameof(Address))] public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public int Floors { get; set; }
        public int NumRooms { get; set; }
        public int BuildYear { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; } = new HashSet<Apartment>();
    }
}
