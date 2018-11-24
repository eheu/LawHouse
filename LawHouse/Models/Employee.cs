namespace BusinessLogic.Models
{
    class Employee : Entity
    {
        public Employee()
        {
        }

        public Employee(string firstName, string lastName, int roleID, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            RoleID = roleID;
            Email = email;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleID { get; set; }
        public string Email { get; set; }
    }
}
