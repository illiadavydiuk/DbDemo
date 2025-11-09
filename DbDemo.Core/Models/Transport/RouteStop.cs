using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Transport
{
    public class RouteStop
    {
        [ForeignKey(nameof(Route))] public int RouteId { get; set; }
        public virtual Route Route { get; set; }

        [ForeignKey(nameof(Stop))] public int StopId { get; set; }
        public virtual Stop Stop { get; set; }

        public int OrderNumber { get; set; }
    }
}
