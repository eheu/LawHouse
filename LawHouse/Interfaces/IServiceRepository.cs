using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    /// <summary>
    /// Repository interface for Services.
    /// </summary>
    public interface IServiceRepository : IRepository<Service>
    {
        /// <summary>
        ///     Get all services from a case
        /// </summary>
        List<Service> GetServicesOnCase(Case @case);
    }
}
