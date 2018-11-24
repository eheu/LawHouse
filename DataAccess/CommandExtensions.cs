using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public static class CommandExtensions
    {
        public static SqlParameter AddParameter(this SqlCommand command, string name, object value)
        {
            var p = command.CreateParameter();
            p.ParameterName = name;
            p.Value = value ?? DBNull.Value;
            command.Parameters.Add(p);
            return p;
        }
    }
}