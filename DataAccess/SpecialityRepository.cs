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
        public void Create(Speciality entity)
        {
            throw new NotImplementedException();
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
                    command.CommandText = @"SELECT [ID], [Name], [Decription] 
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

        public void Update(Speciality entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Speciality entity)
        {
            throw new NotImplementedException();
        }

        private static void Map(SqlDataReader reader, Speciality speciality)
        {
            speciality.ID = (int)reader[0];
            speciality.Name = (string)reader[1];
            speciality.Decription = (string)reader[2];
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
