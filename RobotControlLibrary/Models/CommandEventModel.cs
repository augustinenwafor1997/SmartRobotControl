using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControlLibrary.Models
{
    public class CommandEventModel
    {
        /// <summary>
        /// Gets or sets the unique identifier for the command event.
        /// </summary>
        public long CommandEventId { get; set; }
        /// <summary>
        /// Gets or sets the unique identifier for the command.
        /// </summary>
        public int CommandId { get; set; }
        /// <summary>
        /// Gets or sets the initial status of the entity before a transition occurs.
        /// </summary>
        public string FromStatus { get; set; }
        /// <summary>
        /// Gets or sets the new status of the entity after a transition occurs.
        /// </summary>
        public string ToStatus { get; set; }
        /// <summary>
        /// Gets or sets the message content.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Gets or sets the date and time when the entity was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}
