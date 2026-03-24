namespace s33546;

public class Projector : Device
{
    public Projector(string model, string resolution, double weight) : base("Projector")
    {
        Resolution = resolution;
        Weight = weight;
        Model = model;
    }

    public string Resolution { get;set; }
    public double Weight { get;set;}
    
    public string Model { get;set;}
}