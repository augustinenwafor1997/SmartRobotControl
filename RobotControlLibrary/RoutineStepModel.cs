using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControlLibrary
{
    
    public class RoutineStepModel
    {
        public int RoutineStepId { get; set; }
        public int RoutineId { get; set; }
        public int StepOrder { get; set; }
        public string CommandType { get; set; }
        public string PayloadJson { get; set; }
        public int? DwellMs { get; set; }
    }
}
