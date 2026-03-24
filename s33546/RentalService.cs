namespace s33546;

public class RentalService
{
    private List<Device> devicesToRent = new List<Device>();
    private List<Rental> rentedDevices = new List<Rental>();

    public void AddDevice(Device device)
    {
        devicesToRent.Add(device);
        Console.WriteLine("Dodano do systemu: " +  device.Name + ", o modelu: " +  device.Model);
    }

    public void RentDevice(User user, Device device, DateTime dateFrom, DateTime dateTo)
    {
        if (!device.IsAvailable)
        {
            Console.WriteLine("BŁĄD: " + device.Name + ", o modelu: " + device.Model + " jest już wypożyczony");
            return;
        }
        var countRents = rentedDevices.Count(r => r.RentedTo == user);
        if ((countRents >= 2 && user.UserType == "Student") ||  (countRents >= 5 && user.UserType == "Employee"))
        {
            Console.WriteLine("BŁĄD: " + user.UserType + " ma już maksymalną ilość możliwych wypożyczeń");
            return;
        }
        
        device.IsAvailable = false;
        rentedDevices.Add(new Rental(user, device, dateFrom, dateTo));
        Console.WriteLine("Wypożyczono: " + device.Model + ", osobie: " + user.FirstName + " " + user.LastName );
    }

    public void ShowAvaibleDevices()
    {   
        Console.WriteLine("DOSTĘPNE SPRZĘTY: ");
        var avaibleDevices =  devicesToRent.Where(d => d.IsAvailable).ToList();
        if (avaibleDevices.Count == 0)
        {
            Console.WriteLine("Brak atualnie sprzętu do wypożyczenia");
            return;
        }

        foreach (var device in avaibleDevices)
        {
            Console.WriteLine("- " + device.Name + " " +  device.Model);
        }
    }
    
}