using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControlLibrary
{
   

    public class LogEntryModel
    {
        public long LogId { get; set; }
        public string DeviceId { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        public string ContextJson { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
