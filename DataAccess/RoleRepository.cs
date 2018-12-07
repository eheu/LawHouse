using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoleRepository : IRoleRepository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Settings.Default.ConnectionString);
        public void Create(Role entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public void Delete(Role entity)
        {
            throw new NotImplementedException();
        }

        public Role Get(int ID)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = @"SELECT [ID], [Name] 
                                            FROM [Role]
                                            WHERE ID = @ID";
                    command.AddParameter("ID", ID);
                    _connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new DataException("Role with ID " + ID + " not found");

                        var Role = new Role();
                        Map(reader, Role);

                        return Role;
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                finally
                {
                    _connection.Close();
                }
            }
        }

        public List<Role> GetAll()
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = @"SELECT [ID], [Name] 
                                        FROM [Role]";
                    return MapCollection(command);
                }
                catch (Exception)
                {

                    throw;
                }

                finally
                {
                    _connection.Close();
                }
            }
        }

        public void Update(Role entity)
        {
            throw new NotImplementedException();
        }

        private static void Map(SqlDataReader reader, Role role)
        {
            role.ID = (int)reader[0];
            role.Name = (string)reader[1];
        }
        private static List<Role> MapCollection(SqlCommand command)
        {
            using (var reader = command.ExecuteReader())
            {
                var employees = new List<Role>();
                while (reader.Read())
                {
                    var role = new Role();
                    Map(reader, role);
                    employees.Add(role);
                }
                return employees;
            }
        }
    }
}
