using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Settings.Default.ConnectionString);
        public void Create(Service entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Service Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Service> GetAll()
        {
            using (var command = _connection.CreateCommand())
            {
                _connection.Open();
                command.CommandText = @"SELECT ID, name, price, isHourly 
                                        FROM Service";
                return MapCollection(command);
            }
        }

        public void Update(Service entity)
        {
            throw new NotImplementedException();
        }

        private static void Map(SqlDataReader reader, Service service)
        {
            service.ID = (int)reader[0];
            service.Name = (string)reader[1];
            service.Price = (decimal)reader[2];
            service.IsHourly = (bool)reader[3];
        }
        private static List<Service> MapCollection(SqlCommand command)
        {
            using (var reader = command.ExecuteReader())
            {
                var services = new List<Service>();
                while (reader.Read())
                {
                    var service = new Service();
                    Map(reader, service);
                    services.Add(service);
                }
                return services;
            }
        }

        public List<Service> GetServicesOnCase(Case @case)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = @"SELECT *
                                            FROM [Case]
                                            JOIN CaseService ON [Case]";
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

    }
}
