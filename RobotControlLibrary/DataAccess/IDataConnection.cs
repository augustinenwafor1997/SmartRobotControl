using RobotControlLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControlLibrary.DataAccess
{
    public interface IDataConnection
    {
        // User Operations
        UserAccountModel AuthenticateUser(string username, string password);
        List<UserAccountModel> GetAllUsers();
        UserAccountModel CreateUser(string username, string password, string role);
        bool UpdateUserRole(int userId, string newRole);
        bool DeleteUser(int userId);
        bool ResetUserPassword(int userId, string newPassword);

        // Device Operations
        List<DeviceModel> GetAllDevices();
        DeviceModel GetDeviceById(string deviceId);
        bool UpdateDeviceStatus(string deviceId, string status, DateTime lastHeartbeat);

        // Command Operations
        List<CommandModel> GetRecentCommands(int count);
        List<CommandModel> GetCommandsByDevice(string deviceId);
        CommandModel CreateCommand(string deviceId, string commandType, string payloadJson, int requestedBy);
        bool UpdateCommandStatus(int commandId, string status, string resultMessage = null);

        // Routine Operations
        List<RoutineModel> GetAllRoutines();
        RoutineModel GetRoutineById(int routineId);
        RoutineModel CreateRoutine(string name, string description, int createdBy, List<RoutineStepModel> steps);
        bool DeleteRoutine(int routineId);

        // Log Operations
        List<LogEntryModel> GetRecentLogs(int count);
        List<LogEntryModel> GetFilteredLogs(string deviceId, string level, DateTime? fromDate, DateTime? toDate);
        bool CreateLog(string deviceId, string level, string message, string contextJson = null);
    }
}

