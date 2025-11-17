using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControlLibrary.Models
{
    public class CommandModel
    {
        public int CommandId { get; set; }
        public string DeviceId { get; set; }
        public string CommandType { get; set; }
        public string PayloadJson { get; set; }
        public string Status { get; set; }
        public Guid? GroupId { get; set; }
        public int RequestedBy { get; set; }
        public DateTime RequestedAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string ResultMessage { get; set; }
    }

}
