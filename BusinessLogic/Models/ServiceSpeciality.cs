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
