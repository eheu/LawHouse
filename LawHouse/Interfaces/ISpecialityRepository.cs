using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    /// <summary>
    /// repository interfaces for Specialities.
    /// </summary>
    public interface ISpecialityRepository : IRepository<Speciality>
    {

        List<Speciality> GetSpecialitiesFromLawyer(Employee employee);
        List<Speciality> GetSpecialitiesFromService(Service service);
        void AddSpecialitiesToLawyer(Employee employee, List<Speciality> Specialitylist);

        void AddSpecialityToLawyer(Employee employee, Speciality speciality);
    }
}
