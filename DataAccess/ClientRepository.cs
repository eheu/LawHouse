using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;

namespace DataAccess
{
    class ClientRepository : IClientRepository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public void Create(Client entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Client Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll()
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = @"SELECT ID, title, description, status, startDate, endDate, clientID, employeeID
                                        FROM Case";
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
            client.FirstName = (string)reader[0];
            client.LastName = (string)reader[1];
            client.Phone = (int)reader[2];
            client.Address = (string)reader[3];
            client.Email = (string)reader[4];
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
