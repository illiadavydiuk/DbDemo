using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Transport
{
    public class Schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScheduleId { get; set; }

        [ForeignKey(nameof(Trip))] public int TripId { get; set; }
        public virtual Trip Trip { get; set; }

        public DateTime DepartureTime { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public string Status { get; set; }
    }
}
