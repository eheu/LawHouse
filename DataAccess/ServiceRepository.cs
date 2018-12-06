using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Settings.Default.ConnectionString);
        public void Create(Service entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Service service)
        {
            throw new NotImplementedException();
        }

        public Service Get(int ID)
        {
            try
            {
                using (var command = _connection.CreateCommand())
                {
                    command.CommandText = @"SELECT [ID], [name], [price], [isHourly]
                                        FROM [Service]
                                            WHERE ID = @ID";
                    command.AddParameter("ID", ID);
                    _connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read()) throw new DataException("Case with ID " + ID + " not found");
                        var entity = new Service();
                        Map(reader, entity);
                        return entity;
                    }
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

        public List<Service> GetAll()
        {
            try
            {
                using (var command = _connection.CreateCommand())
                {
                    _connection.Open();
                    command.CommandText = @"SELECT ID, name, price, isHourly, description
                                        FROM Service";
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


        public void Update(Service entity)
        {
            throw new NotImplementedException();
        }

        private static void Map(SqlDataReader reader, Service service)
        {
            service.ID = (int)reader[0];
            service.Name = (string)reader[1];
            service.Price = (double)reader[2];
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

    }
}
