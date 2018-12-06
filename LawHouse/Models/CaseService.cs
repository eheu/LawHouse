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

        public CaseService(int caseID, int serviceID, float hours, float kilometres, float estimatedHours)
        {
            CaseID = caseID;
            ServiceID = serviceID;
            Hours = hours;
            Kilometres = kilometres;
            EstimatedHours = estimatedHours;
        }

        public int CaseID { get; set; }
        public int ServiceID { get; set; }
        public float Hours { get; set; }
        public float Kilometres { get; set; }
        public float EstimatedHours { get; set; }
    }
}
