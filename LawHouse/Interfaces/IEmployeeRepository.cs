using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        /// <summary>
        /// Gets a list with all lawyers
        /// </summary>
        List<Employee> GetAllLawyers();
        /// <summary>
        /// Gets a list with all qualified lawyers
        /// </summary>
        List<Employee> GetAllQualifiedLawyers();

    }
}
