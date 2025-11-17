using RobotControlLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControlLibrary
{
    public static class SessionManager
    {
        public static int CurrentUserId { get; private set; }
        public static string CurrentUsername { get; private set; }
        public static string CurrentUserRole { get; private set; }

        public static bool IsAuthenticated => CurrentUserId > 0;

        public static bool IsAdmin => CurrentUserRole == "Admin";

        public static void SetCurrentUser(UserAccountModel user)
        {
            CurrentUserId = user.UserId;
            CurrentUsername = user.Username;
            CurrentUserRole = user.Role;
        }

        public static void ClearSession()
        {
            CurrentUserId = 0;
            CurrentUsername = null;
            CurrentUserRole = null;
        }
    }
}
