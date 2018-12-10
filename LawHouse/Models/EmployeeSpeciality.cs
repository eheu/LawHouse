using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class EmployeeSpeciality : BaseEntity
    {
        public EmployeeSpeciality(int employeeID, int specialityID)
        {
            this.employeeID = employeeID;
            this.specialityID = specialityID;
        }

        public int employeeID { get; set; }
        public int specialityID { get; set; }
    }
}
