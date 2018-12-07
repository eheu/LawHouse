using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    /// <summary>
    /// Repository interface for Cases.
    /// </summary>
    public interface ICaseRepository : IRepository<Case>
    {
        /// <summary>
        ///     Load all cases with a relation to the client.
        /// </summary>
        List<Case> GetCasesFromClient(int clientID);

        /// <summary>
        ///     Load all cases with a relation to the lawyer.
        /// </summary>
        List<Case> GetCasesFromLawyer(int lawyerID);
        /// <summary>
        ///     Load all existing entities that has status 1 (done). 
        /// </summary>
        List<Case> GetAllDoneCases();



    }
}
