using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    /// <summary>
    /// repository interfaces for Specialities.
    /// </summary>
    public interface ISpecialityRepository : IRepository<Speciality>
    {

        List<Speciality> GetAllSpecialityesFromOnelaywer(int employeeID);

    }
}
