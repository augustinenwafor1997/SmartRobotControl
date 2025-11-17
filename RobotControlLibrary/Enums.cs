using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControlLibrary
{
    public enum DeviceStatus
    {
        Offline,
        Idle,
        Active,
        Error
    }

    public enum CommandStatus
    {
        Pending,
        InProgress,
        Completed,
        Failed,
        Cancelled
    }

    public enum RobotCommandType
    {
        Pick,
        Place,
        MoveForward,
        Reverse,
        TurnLeft,
        TurnRight,
        AboutTurn,
        Home,
        Stop
    }

    public enum LogLevel
    {
        Info,
        Warn,
        Error
    }

    public enum UserRole
    {
        Admin,
        Operator,
        Viewer
    }
}
