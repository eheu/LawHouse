using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;


namespace BusinessLogic.Interfaces
{
    public interface ICaseServiceRepository : IRepository<CaseService>
    {
        /// <summary>
        ///     Get all services from a case
        /// </summary>
        List<Service> GetServicesOnCase(Case @case);


        /// <summary>
        ///     Add services to a case.
        /// </summary>
        void AddServiceToCase(Service service, Case @case);
    }
}
