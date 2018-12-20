namespace BusinessLogic.Models
{
    public class Role : IDEntity
    {
        public Role()
        {
        }

        public Role(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
