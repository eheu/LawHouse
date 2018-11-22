    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Case : Entity
    {
        public Case()
        {

        }
        public Case(string title, string description, bool status, DateTime startDate, DateTime endDate, int clientID, int employeeID)
        {
            Title = title;
            Description = description;
            Status = status;
            StartDate = startDate;
            EndDate = endDate;
            ClientID = clientID;
            EmployeeID = employeeID;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientID { get; set; }
        public int EmployeeID { get; set; }
    }
}
