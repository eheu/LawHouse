using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Employees;
using DataAccess;

namespace BusinessLogic
{
    public class LawHouse
    {
        public IEmployeeRepository Employees { get; private set; } 

        public LawHouse()
        {                
                Employees = new EmployeeRepository();
        }
    }
}
