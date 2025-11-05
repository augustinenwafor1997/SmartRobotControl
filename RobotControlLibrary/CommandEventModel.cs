using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControlLibrary
{
    public class CommandEventModel
    {
        public long CommandEventId { get; set; }
        public int CommandId { get; set; }
        public string FromStatus { get; set; }
        public string ToStatus { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
