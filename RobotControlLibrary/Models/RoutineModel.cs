using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControlLibrary.Models
{
    
    public class RoutineModel
    {
        public int RoutineId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<RoutineStepModel> Steps { get; set; } = new();
    }
}
