namespace s33546;

public class Student : User
{
    public Student(string firstName, string lastName, string userType, string fieldOfStudy) : base(firstName, lastName, "Student")
    {
        FieldOfStudy = fieldOfStudy;
    }

    public string FieldOfStudy { get; set; }
    
}