namespace BusinessLogic.Models
{
    public class Speciality : Entity
    {
        public Speciality()
        {
        }

        public Speciality(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
