using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class ServiceSpeciality : BaseEntity
    {
        public ServiceSpeciality()
        {
        }

        public ServiceSpeciality(int serviceID, int specialityID)
        {
            ServiceID = serviceID;
            SpecialityID = specialityID;
        }

        public int ServiceID { get; set; }
        public int SpecialityID { get; set; }
    }
}
