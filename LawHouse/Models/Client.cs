namespace BusinessLogic.Models
{
    public class Client : Entity
    {
        public Client()
        {
        }

        public Client(string firstName, string lastName, int phone, string address, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Address = address;
            Email = email;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
