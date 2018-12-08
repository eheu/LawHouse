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
            throw new NotImplementedException();
        }

        public void Delete(ServiceSpeciality serviceSpeciality)
        {
            throw new NotImplementedException();
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
