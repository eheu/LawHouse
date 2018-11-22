using System;
using System.Data;


namespace DataAccess
{
    public static class CommandExtensions
    {
        public static IDataParameter AddParameter(this IDbCommand command, string name, object value)
        {
            var p = command.CreateParameter();
            p.ParameterName = name;
            p.Value = value ?? DBNull.Value;
            command.Parameters.Add(p);
            return p;
        }
    }
}