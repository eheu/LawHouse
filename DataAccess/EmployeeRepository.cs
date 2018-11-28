using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using System.Data.SqlClient;


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

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllLawyers()
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
