using Dapper;
using RobotControlLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControlLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        #region User Operations

        public UserAccountModel AuthenticateUser(string username, string password)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Username", username);

                var user = connection.QueryFirstOrDefault<UserAccountModel>(
                    "dbo.spUsers_Authenticate",
                    p,
                    commandType: CommandType.StoredProcedure);

                if (user != null && PasswordHelper.VerifyPassword(password, user.PasswordHash))
                {
                    return user;
                }

                return null;
            }
        }

        public List<UserAccountModel> GetAllUsers()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                return connection.Query<UserAccountModel>(
                    "dbo.spUsers_GetAll",
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public UserAccountModel CreateUser(string username, string password, string role)
        {
            byte[] passwordHash = PasswordHelper.HashPassword(password);

            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Username", username);
                p.Add("@PasswordHash", passwordHash);
                p.Add("@Role", role);
                p.Add("@UserId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUsers_Create", p, commandType: CommandType.StoredProcedure);

                int userId = p.Get<int>("@UserId");

                return new UserAccountModel
                {
                    UserId = userId,
                    Username = username,
                    PasswordHash = passwordHash,
                    Role = role,
                    CreatedAt = DateTime.UtcNow
                };
            }
        }

        public bool UpdateUserRole(int userId, string newRole)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@UserId", userId);
                p.Add("@Role", newRole);

                int rowsAffected = connection.Execute(
                    "dbo.spUsers_UpdateRole",
                    p,
                    commandType: CommandType.StoredProcedure);

                return rowsAffected > 0;
            }
        }

        public bool DeleteUser(int userId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@UserId", userId);

                int rowsAffected = connection.Execute(
                    "dbo.spUsers_Delete",
                    p,
                    commandType: CommandType.StoredProcedure);

                return rowsAffected > 0;
            }
        }

        public bool ResetUserPassword(int userId, string newPassword)
        {
            byte[] newPasswordHash = PasswordHelper.HashPassword(newPassword);

            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@UserId", userId);
                p.Add("@PasswordHash", newPasswordHash);

                int rowsAffected = connection.Execute(
                    "dbo.spUsers_ResetPassword",
                    p,
                    commandType: CommandType.StoredProcedure);

                return rowsAffected > 0;
            }
        }

        #endregion

        #region Device Operations

        public List<DeviceModel> GetAllDevices()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                return connection.Query<DeviceModel>(
                    "dbo.spDevices_GetAll",
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public DeviceModel GetDeviceById(string deviceId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@DeviceId", deviceId);

                return connection.QueryFirstOrDefault<DeviceModel>(
                    "dbo.spDevices_GetById",
                    p,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public bool UpdateDeviceStatus(string deviceId, string status, DateTime lastHeartbeat)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@DeviceId", deviceId);
                p.Add("@Status", status);
                p.Add("@LastHeartbeat", lastHeartbeat);

                int rowsAffected = connection.Execute(
                    "dbo.spDevices_UpdateStatus",
                    p,
                    commandType: CommandType.StoredProcedure);

                return rowsAffected > 0;
            }
        }

        #endregion

        #region Command Operations

        public List<CommandModel> GetRecentCommands(int count)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Count", count);

                return connection.Query<CommandModel>(
                    "dbo.spCommands_GetRecent",
                    p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<CommandModel> GetCommandsByDevice(string deviceId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@DeviceId", deviceId);

                return connection.Query<CommandModel>(
                    "dbo.spCommands_GetByDevice",
                    p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public CommandModel CreateCommand(string deviceId, string commandType, string payloadJson, int requestedBy)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@DeviceId", deviceId);
                p.Add("@CommandType", commandType);
                p.Add("@PayloadJson", payloadJson);
                p.Add("@RequestedBy", requestedBy);
                p.Add("@CommandId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCommands_Create", p, commandType: CommandType.StoredProcedure);

                int commandId = p.Get<int>("@CommandId");

                return new CommandModel
                {
                    CommandId = commandId,
                    DeviceId = deviceId,
                    CommandType = commandType,
                    PayloadJson = payloadJson,
                    Status = "Pending",
                    RequestedBy = requestedBy,
                    RequestedAt = DateTime.UtcNow
                };
            }
        }

        public bool UpdateCommandStatus(int commandId, string status, string resultMessage = null)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@CommandId", commandId);
                p.Add("@Status", status);
                p.Add("@ResultMessage", resultMessage);

                int rowsAffected = connection.Execute(
                    "dbo.spCommands_UpdateStatus",
                    p,
                    commandType: CommandType.StoredProcedure);

                return rowsAffected > 0;
            }
        }

        #endregion

        #region Routine Operations

        public List<RoutineModel> GetAllRoutines()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                return connection.Query<RoutineModel>(
                    "dbo.spRoutines_GetAll",
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public RoutineModel GetRoutineById(int routineId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@RoutineId", routineId);

                // Get the routine first
                var routine = connection.QueryFirstOrDefault<RoutineModel>(
                    "dbo.spRoutines_GetById",
                    p,
                    commandType: CommandType.StoredProcedure);

                if (routine != null)
                {
                    // Get the steps
                    routine.Steps = connection.Query<RoutineStepModel>(
                        "dbo.spRoutineSteps_GetByRoutineId",
                        p,
                        commandType: CommandType.StoredProcedure).ToList();
                }

                return routine;
            }
        }

        public RoutineModel CreateRoutine(string name, string description, int createdBy, List<RoutineStepModel> steps)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", name);
                p.Add("@Description", description);
                p.Add("@CreatedBy", createdBy);
                p.Add("@RoutineId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spRoutines_Create", p, commandType: CommandType.StoredProcedure);

                int routineId = p.Get<int>("@RoutineId");

                // Insert steps
                foreach (RoutineStepModel step in steps)
                {
                    p = new DynamicParameters();
                    p.Add("@RoutineId", routineId);
                    p.Add("@StepOrder", step.StepOrder);
                    p.Add("@CommandType", step.CommandType);
                    p.Add("@PayloadJson", step.PayloadJson);
                    p.Add("@DwellMs", step.DwellMs);

                    connection.Execute("dbo.spRoutineSteps_Insert", p, commandType: CommandType.StoredProcedure);
                }

                return GetRoutineById(routineId);
            }
        }

        public bool DeleteRoutine(int routineId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@RoutineId", routineId);

                int rowsAffected = connection.Execute(
                    "dbo.spRoutines_Delete",
                    p,
                    commandType: CommandType.StoredProcedure);

                return rowsAffected > 0;
            }
        }

        #endregion

        #region Log Operations

        public List<LogEntryModel> GetRecentLogs(int count)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Count", count);

                return connection.Query<LogEntryModel>(
                    "dbo.spLogs_GetRecent",
                    p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<LogEntryModel> GetFilteredLogs(string deviceId, string level, DateTime? fromDate, DateTime? toDate)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@DeviceId", deviceId);
                p.Add("@Level", level);
                p.Add("@FromDate", fromDate);
                p.Add("@ToDate", toDate);

                return connection.Query<LogEntryModel>(
                    "dbo.spLogs_GetFiltered",
                    p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public bool CreateLog(string deviceId, string level, string message, string contextJson = null)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
            {
                var p = new DynamicParameters();
                p.Add("@DeviceId", deviceId);
                p.Add("@Level", level);
                p.Add("@Message", message);
                p.Add("@ContextJson", contextJson);

                int rowsAffected = connection.Execute(
                    "dbo.spLogs_Create",
                    p,
                    commandType: CommandType.StoredProcedure);

                return rowsAffected > 0;
            }
        }

        #endregion
    }
}