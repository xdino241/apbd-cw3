namespace s33546;

public abstract class Device
{
    public bool IsAvailable { get; set; } = true;
    
    private static int _nextId = 1;
    public int Id {get; private set;}
    public string Name {get; set;}
    
    public string Model {get; set;}
    protected  Device(string name, string model)
    {
        Id = _nextId++;
        Name = name;
        Model = model;
    }
}