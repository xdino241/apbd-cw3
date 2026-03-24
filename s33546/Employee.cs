namespace s33546;

public class Employee : User
{
    public Employee(string firstName, string lastName, string userType, string position) : base(firstName, lastName, "Employee")
    {
        Position = position;
    }

    public string Position { get; set; }
    
}