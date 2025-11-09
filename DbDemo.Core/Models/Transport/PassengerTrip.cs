using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Transport
{
    // composite PK (PassengerId, TripId) конфігурується у Fluent API
    public class PassengerTrip
    {
        [ForeignKey(nameof(Passenger))] public int PassengerId { get; set; }
        public virtual Passenger Passenger { get; set; }

        [ForeignKey(nameof(Trip))] public int TripId { get; set; }
        public virtual Trip Trip { get; set; }

        public string Seat { get; set; }
    }
}
