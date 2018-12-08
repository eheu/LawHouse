using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using Microsoft.SqlServer.Server;
using System.Globalization;

namespace DataAccess
{
    public class CaseRepository : ICaseRepository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public void Create(Case @case)
        {
            using (var cmd = _connection.CreateCommand())
            {
                try
                {
                    cmd.CommandText = @"INSERT INTO [Case] (title, description, status, startDate, endDate, clientID, employeeID)
                                        VALUES(@title, @description, @status, @startDate, @endDate, @clientID, @employeeID);
                                        SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    cmd.AddParameter("title", @case.Title);
                    cmd.AddParameter("description", @case.Description);
                    cmd.AddParameter("status", @case.Status);
                    cmd.AddParameter("startDate", DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    cmd.AddParameter("endDate", null);
                    cmd.AddParameter("clientID", @case.ClientID);
                    cmd.AddParameter("employeeID", @case.EmployeeID);
                    _connection.Open();
                    var ID = (int)cmd.ExecuteScalar();
                    @case.ID = ID;
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

        public Case Get(int ID)
        {
            try
            {
                using (var command = _connection.CreateCommand())
                {
                    command.CommandText = @"SELECT [ID], [title], [description], [status], [startDate], [endDate], [hoursSum], [estimatedHoursSum], [clientID], [employeeID]
                                        FROM [Case]
                                            WHERE ID = @ID";
                    command.AddParameter("ID", ID);
                    _connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read()) throw new DataException("Case with ID " + ID + " not found");
                        var entity = new Case();
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

        public List<Case> GetAll()
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = @"SELECT ID, title, description, status, startDate, endDate, clientID, employeeID
                                        FROM [Case]";
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

        public List<Case> GetCasesFromClient(int clientID)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = @"SELECT ID, title, description, status, startDate, endDate, clientID, employeeID
                                            FROM [Case] 
                                            WHERE ID = @clientID";
                    command.AddParameter("clientID", @clientID);
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

        public List<Case> GetCasesFromLawyer(int lawyerID)
        {
            throw new NotImplementedException();
        }


        public void Update(Case @case)
        {

            using (var command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = @"UPDATE [Case] SET
                                            title = @title, 
                                            description = @description, 
                                            status = @status, 
                                            clientID = @clientID, 
                                            employeeID = @employeeID
                                            WHERE ID = @ID";
                    command.AddParameter("ID", @case.ID);
                    command.AddParameter("title", @case.Title);
                    command.AddParameter("description", @case.Description);
                    command.AddParameter("status", @case.Status);
                    command.AddParameter("clientID", @case.ClientID);
                    command.AddParameter("employeeID", @case.EmployeeID);
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

        public void Delete(Case @case)
        {
            using (var cmd = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    cmd.CommandText = @"DELETE FROM [Case]
                                        WHERE ID = @ID";
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

        private static void Map(SqlDataReader reader, Case @case)
        {
            @case.ID = (int)reader[0];
            @case.Title = (string)reader[1];
            @case.Description = (string)reader[2];
            @case.Status = (bool)reader[3];
            @case.StartDate = (DateTime)reader[4];
            @case.EndDate = reader[5] == DBNull.Value ? default(DateTime) : (DateTime)reader[5];
            @case.ClientID = (int)reader[6];
            @case.EmployeeID = (int)reader[7];
        }
        private static List<Case> MapCollection(SqlCommand command)
        {
            using (var reader = command.ExecuteReader())
            {
                var items = new List<Case>();
                while (reader.Read())
                {
                    var item = new Case();
                    Map(reader, item);
                    items.Add(item);
                }
                return items;
            }
        }



    }
}
