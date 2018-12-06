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

        void SetAllSpecialityesOnOnelaywer(int employeeID, List<Speciality> Specialitylist);

        void AddOneSpecialityOnLaywer(int employeeID, Speciality speciality);
    }
}
