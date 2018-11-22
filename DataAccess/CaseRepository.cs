using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace DataAccess
{
    public class CaseRepository : ICaseRepository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public void Create(Case @case)
        {
            if (@case == null) throw new ArgumentNullException("entity");
            using (var cmd = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();

                    cmd.CommandText = @"INSERT INTO Case (title, description, status, startDate, endDate, clientID, employeeID)
                                        VALUES(@title, @description, @status, @startDate, @endDate, @clientID, @employeeID);
                                        SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    cmd.AddParameter("title", @case.Title);
                    cmd.AddParameter("description", @case.Description);
                    cmd.AddParameter("status", @case.Status);
                    cmd.AddParameter("startDate", @case.StartDate);
                    cmd.AddParameter("endDate", @case.EndDate);
                    cmd.AddParameter("clientID", @case.ClientID);
                    cmd.AddParameter("employeeID", @case.EmployeeID);
                    var ID = (int)cmd.ExecuteScalar();
                    @case.ID = ID;
                }
                catch (Exception exception)
                {
                    throw exception;
                }
                finally
                {
                    _connection.Close();
                }
            }
        }

        public Case Get(int ID)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = @"SELECT [ID], [title], [description], [status], [startDate], [endDate], [hoursSum], [estimatedHoursSum], [clientID], [employeeID]
                                            FROM [Case]
                                            WHERE ID = @ID";
                    command.AddParameter("ID", ID);
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read()) throw new DataException("Not found");
                        var entity = new Case();
                        Map(reader, entity);
                        return entity;
                    }
                }
                catch (Exception exception)
                {
                    throw exception;
                }
                finally
                {
                    _connection.Close();
                }
            }
        }

        public List<Case> GetCasesFromClient(int clientID)
        {
            throw new NotImplementedException();
        }

        public List<Case> GetCasesFromLawyer(int lawyerID)
        {
            throw new NotImplementedException();
        }

        public List<Case> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
        }

        public void Delete(Case entity)
        {
        }

        public void Update(Entity entity)
        {
        }

        private static void Map(IDataRecord record, Case dto)
        {
            dto.ID = (int)record[0];
            dto.Title = (string)record[1];
            dto.Description = (string)record[2];
            dto.Status = (bool)record[3];
            dto.StartDate = (DateTime)record[4];
            dto.EndDate = (DateTime)record[5];
            dto.ClientID = (int)record[8];
            dto.EmployeeID = (int)record[9];
        }
    }
}
