using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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

        public void Delete(CaseService caseService)
        {
            using (var cmd = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    cmd.CommandText = @"DELETE FROM CaseService
                                      WHERE caseID = @caseID
                                      AND serviceID = @serviceID";
                    cmd.AddParameter("caseID", caseService.CaseID);
                    cmd.AddParameter("serviceID", caseService.ServiceID);
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
        public void DeleteAllServicesOnACase(Case @case)
        {
            using (var cmd = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    cmd.CommandText = @"DELETE FROM CaseService
                                    WHERE caseID = @ID";
                    cmd.AddParameter("ID", @case.ID);
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
        public List<CaseService> GetServicesOnCase(Case @case) // fjern? bruges ikke og returnerer CaseService, ikke Case
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
        public Dictionary<CaseService, Service> GetServicesByCaseServiceFromCase(Case @case)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = @"SELECT *
                                            FROM CaseService
                                            JOIN Service
                                            ON CaseService.serviceID = Service.ID
                                            WHERE CaseService.caseID = @caseID";
                    command.AddParameter("caseID", @case.ID);
                    using (var reader = command.ExecuteReader())
                    {
                        Dictionary<CaseService, Service> servicesByCaseService = new Dictionary<CaseService,Service>();
                        while (reader.Read())
                        {
                            CaseService caseService = new CaseService();
                            caseService.CaseID = (int)reader["caseID"];
                            caseService.ServiceID = (int)reader["serviceID"];
                            caseService.Hours = (double)reader["hours"];
                            caseService.Kilometres = (double)reader["kilometres"];
                            caseService.EstimatedHours = (double)reader["estimatedHours"];

                            Service service = new Service();
                            service.ID = (int)reader["ID"];
                            service.Name = (string)reader["name"];
                            service.Price = (double)reader["price"];
                            service.IsHourly = (bool)reader["isHourly"];

                            servicesByCaseService.Add(caseService, service);
                        }
                        return servicesByCaseService;
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
        public void UpdateCaseService(CaseService caseService)
        {
            //Lav SQL til at gemme tid og estimeret tid i databasen 
            //Debug.WriteLine($"Estimated: {caseService.EstimatedHours}. CaseHours: {caseService.Hours}");
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = @"UPDATE CaseService SET
                                            hours = @hours, 
                                            estimatedHours = @estimatedHours, 
                                            kilometres = @kilometres 
                                            WHERE caseID = @caseID
                                            AND serviceID = @serviceID";
                    command.AddParameter("hours", @caseService.Hours);
                    command.AddParameter("estimatedHours", @caseService.EstimatedHours);
                    command.AddParameter("kilometres", @caseService.Kilometres);
                    command.AddParameter("caseID", @caseService.CaseID);
                    command.AddParameter("serviceID", @caseService.ServiceID);
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

        private static void Map(SqlDataReader reader, CaseService caseService)
        {
            caseService.CaseID = (int)reader[0];
            caseService.ServiceID = (int)reader[1];
            caseService.Hours = (double)reader[2];
            caseService.Kilometres = (double)reader[3];
            caseService.EstimatedHours = (double)reader[3];
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
