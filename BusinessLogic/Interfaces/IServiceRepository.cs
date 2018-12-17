using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    /// <summary>
    /// Repository interface for Services.
    /// </summary>
    public interface IServiceRepository : IRepository<Service>
    {
        List<Service> GetServicesFromSpeciality(Speciality speciality);
        List<Service> GetServicesFromEmployee(Employee employee);
    }
}
