    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Case : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Boolean Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientID { get; set; }
        public int EmployeeID { get; set; }
    }
}
