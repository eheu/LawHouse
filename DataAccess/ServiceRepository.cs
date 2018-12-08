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
        public void Create(Service service)
        {
            using (var cmd = _connection.CreateCommand())
            {
                try
                {
                    cmd.CommandText = @"INSERT INTO [Service] (name, price, isHourly, description)
                                        VALUES(@name, @price, @isHourly, @description);
                                        SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    cmd.AddParameter("name", service.Name);
                    cmd.AddParameter("price", service.Price);
                    cmd.AddParameter("isHourly", service.IsHourly);
                    cmd.AddParameter("description", service.Description);
                    _connection.Open();
                    var ID = (int)cmd.ExecuteScalar();
                    service.ID = ID;
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

        public void Delete(Service service)
        {
            using (var cmd = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    cmd.CommandText = @"DELETE FROM [Service]
                                        WHERE ID = @ID";
                    cmd.AddParameter("ID", service.ID);
                    cmd.ExecuteNonQuery();
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


        public void Update(Service service)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = @"UPDATE [Service] SET
                                            name = @name, 
                                            price = @price, 
                                            isHourly = @isHourly, 
                                            description = @description 
                                            WHERE ID = @ID";
                    command.AddParameter("ID", service.ID);
                    command.AddParameter("name", service.Name);
                    command.AddParameter("price", service.Price);
                    command.AddParameter("isHourly", service.IsHourly);
                    command.AddParameter("description", service.Description);
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

        private static void Map(SqlDataReader reader, Service service)
        {
            service.ID = (int)reader["ID"];
            service.Name = (string)reader["name"];
            service.Price = (double)reader["price"];
            service.IsHourly = (bool)reader["isHourly"];
            service.Description = reader["description"] == DBNull.Value ? "" : (string)reader["description"];
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
