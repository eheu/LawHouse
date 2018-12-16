namespace BusinessLogic.Models
{
    public class Client : IDEntity
    {
        public Client()
        {
        }

        public Client(string firstName, string lastName, string phone, string address, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Address = address;
            Email = email;
        }

        public string FullName { get => FirstName + " " + LastName; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }
}
