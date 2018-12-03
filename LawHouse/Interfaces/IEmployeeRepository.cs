using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        /// <summary>
        /// Gets a list of all lawyers
        /// </summary>
        List<Employee> GetAllLawyers();
        /// <summary>
        /// Gets a list of all lawyers who are fully qualified for a list for services (who have at least one qualifying speciality for all of the services)
        /// </summary>
        List<Employee> GetAllFullyQualifiedLawyersFromServices(List<Service> caseServices);
        /// <summary>
        /// Gets a list of all lawyers who are partially qualified for a list of services (who have at least one qualifying speciality for at least one of the services)
        /// </summary>
        List<Employee> GetAllPartiallyQualifiedLawyersFromServices(List<Service> caseServices);
    }
}
