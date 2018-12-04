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
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = @"INSERT INTO [Employee]([firstName], [lastName], [roleID], [email], [phone])
                                            VALUES(@FirstName, @LastName, @RoleID, @Email, @Phone);
                                            SELECT CAST(SCOPE_IDENTITY() AS INT)";
                    command.AddParameter("FirstName", entity.FirstName);
                    command.AddParameter("LastName", entity.LastName);
                    command.AddParameter("RoleID", entity.RoleID);
                    command.AddParameter("Email", entity.Email);
                    command.AddParameter("Phone", entity.Phone);
                    _connection.Open();
                    var ID = (int)command.ExecuteScalar();
                    entity.ID = ID;
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

        public void Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int ID)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = @"SELECT [ID], [firstName], [lastName], [roleID], [email], [phone] 
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
                    command.CommandText = @"SELECT [ID], [firstName], [lastName], [roleID], [email], [phone] 
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
                command.CommandText = @"SELECT ID, firstName, lastName, roleID, email, phone 
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
            employee.ID = (int)reader["ID"];
            employee.FirstName = (string)reader["firstName"];
            employee.LastName = (string)reader["lastName"];
            employee.RoleID = (int)reader["roleID"];
            employee.Email = reader[4] == DBNull.Value ? "" : (string)reader["email"];
            employee.Phone = (string)reader["phone"]; 
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
