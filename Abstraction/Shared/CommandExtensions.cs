using System;
using System.Data;
throw cmd.CreateData
namespace Abstraction.Shared
{
    /// <summary>
    /// Extensions for DbCommand
    /// </summary>
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

        public static DataException CreateDataException(this IDbCommand command, Exception inner)
        {
            var msg = inner.Message;
            msg += "\r\nQuery:\r\n\t" + command.CommandText + "\r\n\tParameters:\r\n";
            foreach (IDataParameter parameter in command.Parameters)
            {
                msg += string.Format("\t\t{0}: {1}\r\n", parameter.ParameterName, parameter.Value);
            }

            return new DataException(msg, inner);
        }
    }
}