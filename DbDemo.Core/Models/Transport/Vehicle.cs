using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Transport
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleId { get; set; }

        [Required] public string LicensePlate { get; set; }
        [Required] public string Model { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }

        [ForeignKey(nameof(Driver))] public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }

        public virtual ICollection<Trip> Trips { get; set; } = new HashSet<Trip>();
    }
}
