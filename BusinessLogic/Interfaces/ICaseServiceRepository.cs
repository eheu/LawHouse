using System.Collections.Generic;
using BusinessLogic.Models;


namespace BusinessLogic.Interfaces
{
    public interface ICaseServiceRepository : IRepository<CaseService>
    {
        /// <summary>
        ///     Get all services from a case
        /// </summary>
        List<CaseService> GetServicesOnCase(Case @case);

        /// <summary>
        ///     Add services to a case.
        /// </summary>
        void AddServiceToCase(Service service, Case @case);

        /// <summary>
        ///     Collects a dictionary with paired caseservice and service information.
        /// </summary>
        Dictionary<CaseService, Service> GetServicesByCaseServiceFromCase(Case @case);

        /// <summary>
        ///     Deletes all services on a specific case
        /// </summary>
        void DeleteAllServicesOnACase(Case @case);
        /// <summary>
        ///     Updates estimated time and or times spend on a case service
        /// </summary>
        void UpdateCaseService(CaseService caseService);
    }
}
