namespace Employee_Management_App.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PhoneNumber { get; set; }
        public Position Position { get; set; }

        public Employee(int id, string firstName, string lastName, string streetAddress, string phoneNumber, Position position)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            FullName = FirstName + " " + LastName;
            StreetAddress = streetAddress;
            PhoneNumber = phoneNumber;
            Position = position;
        }
    }
}
