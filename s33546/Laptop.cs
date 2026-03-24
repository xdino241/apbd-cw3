namespace s33546;

public class Laptop : Device
{
    public int RAM {get; set;}
    public string CPU {get; set;}
    public Laptop(string model, int ram, string cpu) : base("Laptop",  model)
    {
        RAM = ram;
        CPU = cpu;
    }
}