namespace Employee_Management_App.Models
{
    public class Position
    {
        public string Title { get; set; }
        public int Salary { get; set; }

        public Position(string title, int salary)
        {
            Title = title;
            Salary = salary;
        }
    }
}
