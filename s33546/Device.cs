namespace s33546;

public abstract class Device
{
    private static int _nextId = 1;
    public int Id {get; private set;}
    public string Name {get; set;}
    
    protected  Device(string name)
    {
        Id = _nextId++;
        Name = name;
    }
}