using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeSpecialityRepository : IEmployeeSpecialityRepository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Settings.Default.ConnectionString);
        public void Create(EmployeeSpeciality employeeSpeciality)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = @"INSERT INTO [EmployeeSpeciality] 
                                            VALUES (@employeeID, @specialityID)";
                    command.AddParameter("employeeID", employeeSpeciality.employeeID);
                    command.AddParameter("specialityID", employeeSpeciality.specialityID);
                    // no need for SqlParameter when handling IDS - sql injection impossible?
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

        public void Delete(EmployeeSpeciality entity)
        {
            using (var command = _connection.CreateCommand())
            {
                try
                {
                    //Prøv at få dette til at virke
                    //DELETE[DBO].[Employee] , [DBO].[EmployeeSpeciality] FROM[Employee] INNER JOIN[EmployeeSpeciality]
                    //WHERE[Employee].[ID] = [EmployeeSpeciality].[employeeID] and[Employee].[ID] = '23'

                    command.CommandText = @"DELETE FROM [EmployeeSpeciality] 
                                            WHERE [EmployeeSpeciality].[employeeID] = @E_ID AND [EmployeeSpeciality].[specialityID] = @S_ID";

                    command.AddParameter("E_ID", entity.employeeID);
                    command.AddParameter("S_ID", entity.specialityID);
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

        public EmployeeSpeciality Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeSpeciality> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(EmployeeSpeciality entity)
        {
            throw new NotImplementedException();
        }
    }
}
