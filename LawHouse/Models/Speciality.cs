namespace BusinessLogic.Models
{
    class Speciality : Entity
    {
        public Speciality()
        {
        }

        public Speciality(string name, string decription)
        {
            Name = name;
            Decription = decription;
        }

        public string Name { get; set; }
        public string Decription { get; set; }
    }
}
