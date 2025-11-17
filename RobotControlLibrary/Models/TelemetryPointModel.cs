using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControlLibrary.Models
{
      

    public class TelemetryPointModel
    {
        public long TelemetryId { get; set; }
        public string DeviceId { get; set; }
        public string Metric { get; set; }
        public double Value { get; set; }
        public string Unit { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
