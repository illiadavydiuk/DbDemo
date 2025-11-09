using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Housing
{
    public class Apartment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApartmentId { get; set; }

        [ForeignKey(nameof(Building))] public int BuildingId { get; set; }
        public virtual Building Building { get; set; }

        [Required] public string ApartmentNumber { get; set; }
        public decimal Area { get; set; }
        public int NumRooms { get; set; }

        public virtual ICollection<ResidentHousing> Residents { get; set; } = new HashSet<ResidentHousing>();
        public virtual ICollection<UtilityBill> UtilityBills { get; set; } = new HashSet<UtilityBill>();
    }
}
