namespace BusinessLogic.Models
{
    public class CaseService : BaseEntity
    {
        public CaseService()
        {
        }

        public CaseService(int caseID, int serviceID, double hours, double kilometres, double estimatedHours)
        {
            CaseID = caseID;
            ServiceID = serviceID;
            Hours = hours;
            Kilometres = kilometres;
            EstimatedHours = estimatedHours;
        }

        public int CaseID { get; set; }
        public int ServiceID { get; set; }
        public double Hours { get; set; }
        public double Kilometres { get; set; }
        public double EstimatedHours { get; set; }
    }
}
