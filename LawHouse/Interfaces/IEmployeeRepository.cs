using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        List<Employee> GetAllLawyers(); 

    }
}
