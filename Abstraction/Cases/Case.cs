using System;

namespace Abstraction.Cases
{
    public class Case
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Boolean Status { get; set; }
        public int EstimatedHours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientID { get; set; }
        public int EmployeeID { get; set; }

    }
}