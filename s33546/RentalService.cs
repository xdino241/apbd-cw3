namespace s33546;

public class RentalService
{
    public List<Device> Devices = new List<Device>();

    public void addDevice(Device device)
    {
        Devices.Add(device);
        Console.WriteLine("Dodano do systemu: " +  device.Name);
    }
    
    
}