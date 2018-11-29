using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Settings.Default.ConnectionString);
        public void Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int ID)
        {
            using (var command = _connection.CreateCommand())
            {
                _connection.Close();

                try
                {
                    command.CommandText = @"SELECT [ID], [firstName], [lastName], [roleID], [email] 
                                        FROM [Employee]
                                        WHERE ID = @ID";
                    command.AddParameter("ID", ID);
                    _connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new DataException("Employee with ID " + ID + " not found");

                        var entity = new Employee();
                        Map(reader, entity);

                        return entity;
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

        public List<Employee> GetAll()
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = @"SELECT [ID], [firstName], [lastName], [roleID], [email] 
                                        FROM [Employee]";
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

        public List<Employee> GetAllLawyers()
        {
            try
            {
            using (var command = _connection.CreateCommand())
            {
                _connection.Open();
                command.CommandText = @"SELECT ID, firstName, lastName, roleID, email 
                                        FROM Employee
                                        WHERE roleID = 1";
                return MapCollection(command);
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
        public List<Employee> GetAllQualifiedLawyers()
        {
            throw new NotImplementedException();
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }

        private static void Map(SqlDataReader reader, Employee employee)
        {
            employee.ID = (int)reader[0];
            employee.FirstName = (string)reader[1];
            employee.LastName = (string)reader[2];
            employee.RoleID = (int)reader[3];
            employee.Email = reader[4] == DBNull.Value ? "" : (string)reader[4];
        }
        private static List<Employee> MapCollection(SqlCommand command)
        {
            using (var reader = command.ExecuteReader())
            {
                var employees = new List<Employee>();
                while (reader.Read())
                {
                    var employee = new Employee();
                    Map(reader, employee);
                    employees.Add(employee);
                }
                return employees;
            }
        }

    }
}
