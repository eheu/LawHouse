using System;

namespace BusinessLogic.Models
{
    public class Case : IDEntity
    {
        public Case()
        {
        }

        public Case(string title, string description, DateTime startDate, int clientID, int employeeID)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
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
