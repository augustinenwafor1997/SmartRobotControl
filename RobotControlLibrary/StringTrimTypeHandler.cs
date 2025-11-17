using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using System.Data;

namespace RobotControlLibrary
{
    public class StringTrimTypeHandler : SqlMapper.TypeHandler<string>
    {
        public override string Parse(object value)
        {
            // Trim all strings when reading from database
            return value?.ToString()?.Trim();
        }

        public override void SetValue(IDbDataParameter parameter, string value)
        {
            // Optionally trim when writing to database too
            parameter.Value = value?.Trim();
        }
    }
}