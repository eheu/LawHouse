using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class SpecialityRepository : ISpecialityRepository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Settings.Default.ConnectionString);
        public void Create(Speciality speciality)
        {
            using (var cmd = _connection.CreateCommand())
            {
                try
                {
                    cmd.CommandText = @"INSERT INTO [Speciality] (name, description)
                                        VALUES(@name, @description);
                                        SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    cmd.AddParameter("name", speciality.Name);
                    cmd.AddParameter("description", speciality.Description);
                    _connection.Open();
                    var ID = (int)cmd.ExecuteScalar();
                    speciality.ID = ID;
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

        public Speciality Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Speciality> GetAll()
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = @"SELECT [ID], [Name], [Description] 
                                        FROM [Speciality]";
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

        public void AddOneSpecialityOnLaywer(int employeeID, Speciality speciality)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = @"INSERT INTO [EmployeeSpeciality]([employeeID], [specialityID]) 
                                            VALUES (@employeeID, @S_ID)";

                    command.AddParameter("S_ID", speciality.ID);
                    command.AddParameter("employeeID", employeeID);
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

        public void SetAllSpecialityesOnOnelaywer(int employeeID, List<Speciality> Specialitylist)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = @"INSERT INTO [EmployeeSpeciality]([employeeID], [specialityID]) VALUES";

                    for (int i = 0; i < Specialitylist.Count; i++)
                    {
                        command.CommandText += " (@employeeID, @S_ID"+i+")";
                        command.AddParameter("S_ID"+i, Specialitylist[i].ID);
                        if (i < Specialitylist.Count - 1)
                        {
                            command.CommandText += ",";
                        }
                    }

                    command.AddParameter("employeeID", employeeID);
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

        public List<Speciality> GetAllSpecialityesFromOnelaywer(int employeeID)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    command.CommandText = @"SELECT [ID], [Name], [Decription] 
                    FROM [Speciality]
                    INNER JOIN [EmployeeSpeciality] ON [EmployeeSpeciality].[specialityID] = [Speciality].[ID] 
                    AND [EmployeeSpeciality].[employeeID] = @employeeID";
                    command.AddParameter("employeeID", @employeeID);
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

        public void Update(Speciality speciality)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = @"UPDATE [Speciality] SET
                                            name = @name, 
                                            description = @description 
                                            WHERE ID = @ID";
                    command.AddParameter("name", speciality.Name);
                    command.AddParameter("description", speciality.Description);
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

        public void Delete(Speciality speciality)
        {
            using (var cmd = _connection.CreateCommand())
            {
                try
                {
                    _connection.Open();
                    cmd.CommandText = @"DELETE FROM [Speciality]
                                        WHERE ID = @ID";
                    cmd.AddParameter("ID", speciality.ID);
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

        private static void Map(SqlDataReader reader, Speciality speciality)
        {
            speciality.ID = (int)reader[0];
            speciality.Name = (string)reader[1];
            speciality.Description = (string)reader[2];
        }
        private static List<Speciality> MapCollection(SqlCommand command)
        {
            using (var reader = command.ExecuteReader())
            {
                var employees = new List<Speciality>();
                while (reader.Read())
                {
                    var speciality = new Speciality();
                    Map(reader, speciality);
                    employees.Add(speciality);
                }
                return employees;
            }
        }
    }
}
