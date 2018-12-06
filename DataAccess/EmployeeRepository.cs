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
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    //Prøv at få dette til at virke
                    //DELETE[DBO].[Employee] , [DBO].[EmployeeSpeciality] FROM[Employee] INNER JOIN[EmployeeSpeciality]
                    //WHERE[Employee].[ID] = [EmployeeSpeciality].[employeeID] and[Employee].[ID] = '23'

                    command.CommandText = @"Delete from [EmployeeSpeciality] where [EmployeeSpeciality].[employeeID] = @E_ID;
		                                    Delete from [Employee] where [Employee].[ID] = @E_ID";

                    command.AddParameter("E_ID", employee.ID);
                    _connection.Open();
                    command.ExecuteNonQuery();
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
                    command.CommandText = @"SELECT ID, firstName, lastName, phone, email, roleID
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
        public List<Employee> GetAllFullyQualifiedLawyersFromServices(List<Service> services)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = "SELECT * FROM Employee ";
                    if (services.Count > 0)
                    {
                        command.CommandText += @"JOIN EmployeeSpeciality ON Employee.ID = EmployeeSpeciality.employeeID
                                                 JOIN ServiceSpeciality ON EmployeeSpeciality.specialityID = ServiceSpeciality.specialityID
                                                 WHERE serviceID = @ServiceID0";
                        command.AddParameter("ServiceID0", services[0].ID);
                        for (int i = 1; i < services.Count; i++)
                        {
                            command.CommandText += $" AND serviceID = @serviceID{i}";
                            command.AddParameter($"ServiceID{i}", services[i].ID);
                        }
                    }
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
        public List<Employee> GetAllPartiallyQualifiedLawyersFromServices(List<Service> services)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = "SELECT * FROM Employee ";
                    if (services.Count > 0)
                    {
                        command.CommandText += @"JOIN EmployeeSpeciality ON Employee.ID = EmployeeSpeciality.employeeID
                                                 JOIN ServiceSpeciality ON EmployeeSpeciality.specialityID = ServiceSpeciality.specialityID
                                                 WHERE serviceID = @ServiceID0";
                        command.AddParameter("ServiceID0", services[0].ID);
                        for (int i = 1; i < services.Count; i++)
                        {
                            command.CommandText += $" AND serviceID = @serviceID{i}";
                            command.AddParameter($"ServiceID{i}", services[i].ID);
                        }
                    }
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

        public void Update(Employee entity)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = @"UPDATE Employee
                                            SET [firstName]=@FirstName, [lastName]=@LastName, [email]=@Email, [phone]=@Phone, [roleID]=@RoleID
                                            WHERE [ID]=@E_ID";
                    command.AddParameter("FirstName", entity.FirstName);
                    command.AddParameter("LastName", entity.LastName);
                    command.AddParameter("Email", entity.Email);
                    command.AddParameter("Phone", entity.Phone);
                    command.AddParameter("RoleID", entity.RoleID);
                    command.AddParameter("E_ID", entity.ID);

                    _connection.Open();
                    int numberOfRecords = command.ExecuteNonQuery();
                    Console.WriteLine(numberOfRecords);
                    
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

        private static void Map(SqlDataReader reader, Employee employee)
        {
            employee.ID = (int)reader["ID"];
            employee.FirstName = (string)reader["firstName"];
            employee.LastName = (string)reader["lastName"];
            employee.Email = reader["email"] == DBNull.Value ? "" : (string)reader["email"];
            employee.Phone = (string)reader["phone"];
            employee.RoleID = (int)reader["roleID"];
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
