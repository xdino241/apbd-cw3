namespace s33546;

public abstract class User
{
    private static int _nextId = 1;
    public int Id {get; private set;}
    public string FirstName {get; set;}
    public string LastName { get; set; }
    public string UserType { get; protected set; }

    protected User(string firstName, string lastName, string userType)
    {
        Id = _nextId++;
        FirstName = firstName;
        LastName = lastName;
        UserType = userType;
    }
}