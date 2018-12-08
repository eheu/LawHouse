namespace BusinessLogic.Models
{
    public class Speciality : Entity
    {
        public Speciality()
        {
        }

        public Speciality(string name, string decription)
        {
            Name = name;
            Description = decription;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
