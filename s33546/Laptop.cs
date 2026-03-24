namespace s33546;

public class Laptop : Device
{
    public string Model {get; set;}
    public int RAM {get; set;}
    public string CPU {get; set;}
    public Laptop(string model, int ram, string cpu) : base("Laptop")
    {
        Model = model;
        RAM = ram;
        CPU = cpu;
    }
}