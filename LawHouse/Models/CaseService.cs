using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class CaseService : BaseEntity
    {
        public CaseService()
        {
        }

        public CaseService(int caseID, int serviceID, decimal hours, decimal kilometres, decimal estimatedHours)
        {
            CaseID = caseID;
            ServiceID = serviceID;
            Hours = hours;
            Kilometres = kilometres;
            EstimatedHours = estimatedHours;
        }

        public int CaseID { get; set; }
        public int ServiceID { get; set; }
        public decimal Hours { get; set; }
        public decimal Kilometres { get; set; }
        public decimal EstimatedHours { get; set; }
    }
}
