using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;

namespace DataAccess
{
    public class ClientRepository : IClientRepository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public void Create(Client client)
        {
            using (var cmd = _connection.CreateCommand())
            {
                try
                {
                    cmd.CommandText = @"INSERT INTO [Client] (firstName, lastName, phone, address, email)
                                        VALUES(@firstName, @lastName, @phone, @address, @email);
                                        SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    cmd.AddParameter("firstName", @client.FirstName);
                    cmd.AddParameter("lastName", @client.LastName);
                    cmd.AddParameter("phone", @client.Phone);
                    cmd.AddParameter("address", @client.Address);
                    cmd.AddParameter("email", @client.Email);
                    _connection.Open();
                    var ID = (int)cmd.ExecuteScalar();
                    @client.ID = ID;
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

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Client Get(int ID)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = @"SELECT ID, firstName, lastName, phone, address, email 
                                            FROM Client
                                        WHERE ID = @ID";
                    command.AddParameter("ID", ID);
                    _connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new DataException("Employee with ID " + ID + " not found");

                        var entity = new Client();
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

        public List<Client> GetAll()
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                     _connection.Open();
                    command.CommandText = @"SELECT ID, firstName, lastName, phone, address, email 
                                            FROM Client";
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

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }

        private static void Map(SqlDataReader reader, Client client)
        {
            client.ID = (int)reader[0];
            client.FirstName = (string)reader[1];
            client.LastName = (string)reader[2];
            client.Phone = (string)reader[3];
            client.Address = (string)reader[4];
            client.Email = reader[5] == DBNull.Value ? "" : (string)reader[5];
        }
        private static List<Client> MapCollection(SqlCommand command)
        {
            using (var reader = command.ExecuteReader())
            {
                var clients = new List<Client>();
                while (reader.Read())
                {
                    var client = new Client();
                    Map(reader, client);
                    clients.Add(client);
                }
                return clients;
            }
        }
    }
}
