using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;

namespace DataAccess
{
    public class ServiceSpecialityRepository : IServiceSpecialityRepository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public void Create(ServiceSpeciality serviceSpeciality)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = @"INSERT INTO [ServiceSpeciality] 
                                            VALUES (@serviceID, @specialityID)";
                    command.AddParameter("serviceID", serviceSpeciality.ServiceID);
                    command.AddParameter("specialityID", serviceSpeciality.SpecialityID);
                    // no need for sqlparameter when handling IDs - SQL injection impossible?
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

        public void Delete(ServiceSpeciality serviceSpeciality)
        {
            using (var cmd = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    cmd.CommandText = @"DELETE FROM [ServiceSpeciality]
                                        WHERE [serviceID] = @ID1 AND [specialityID] = @ID2";
                    cmd.AddParameter("ID1", serviceSpeciality.ServiceID);
                    cmd.AddParameter("ID2", serviceSpeciality.SpecialityID);
                    Console.WriteLine(cmd.ExecuteNonQuery()); 
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

        public ServiceSpeciality Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ServiceSpeciality> GetAll()
        {
            throw new NotImplementedException();
        }



        public void Update(ServiceSpeciality serviceSpeciality)
        {
            throw new NotImplementedException();
        }
    }
}
