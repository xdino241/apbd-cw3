namespace s33546;

public class Projector : Device
{
    public Projector(string model, string resolution, double weight) : base("Projector", model)
    {
        Resolution = resolution;
        Weight = weight;
    }

    public string Resolution { get;set; }
    public double Weight { get;set;}
}