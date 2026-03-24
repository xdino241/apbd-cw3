namespace s33546;

public class Camera : Device
{
    public Camera(string model,double megapixels, int opticalZoom) : base("Camera", model)
    {
        Megapixels = megapixels;
        OpticalZoom = opticalZoom;
    }

    public double Megapixels{get; set;}
    public int OpticalZoom {get; set;}
    
}