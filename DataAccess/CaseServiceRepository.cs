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
    public class CaseServiceRepository : ICaseServiceRepository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Settings.Default.ConnectionString);
        public void Create(CaseService entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public CaseService Get(int id)
        {
            throw new NotImplementedException();
        }


        public List<CaseService> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(CaseService entity)
        {
            throw new NotImplementedException();
        }

        public void AddServiceToCase(Service service, Case @case)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = @"INSERT INTO CaseService (caseID, serviceID, hours, kilometres, estimatedHours)
                                            VALUES(@caseID, @serviceID, 0, 0, 0)";
                    command.AddParameter("caseID", @case.ID);
                    command.AddParameter("serviceID", service.ID);
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
        public List<CaseService> GetServicesOnCase(Case @case)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = @"SELECT *
                                            FROM CaseService
                                            WHERE caseID =@CaseID";
                    command.AddParameter("CaseID", @case.ID);
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
        private static void Map(SqlDataReader reader, CaseService caseService)
        {
            caseService.CaseID = (int)reader[0];
            caseService.ServiceID = (int)reader[1];
            caseService.Hours = (decimal)reader[2];
            caseService.Kilometres = (decimal)reader[3];
            caseService.EstimatedHours = (decimal)reader[3];
        }
        private static List<CaseService> MapCollection(SqlCommand command)
        {
            using (var reader = command.ExecuteReader())
            {
                var caseServices = new List<CaseService>();
                while (reader.Read())
                {
                    var caseService = new CaseService();
                    Map(reader, caseService);
                    caseServices.Add(caseService);
                }
                return caseServices;
            }
        }

    }
}
