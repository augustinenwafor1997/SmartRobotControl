using Dapper;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using RobotControlLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControlLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; } = null!;
        public static void InitializeConnections()
        {
            // Register custom type handler to trim all strings
            SqlMapper.AddTypeHandler(new StringTrimTypeHandler());

            // For now, we only have SQL Connector. In the future, we can add more types.
            SqlConnector sql = new SqlConnector();
            Connection = sql;
        }

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
