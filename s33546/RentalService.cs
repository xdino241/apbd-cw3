namespace s33546;

public class RentalService
{
    private List<Device> devicesToRent = new List<Device>();
    private List<Rental> rentedDevices = new List<Rental>();
    private List<Rental> rentalHistory = new List<Rental>();

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

    public void ReturnDevice(Device device)
    {
        Rental rent = null;
        foreach (var rental in rentedDevices)
        {
            if (rental.RentedDevice == device)
            {
                rent = rental;
                break;
            }
        }
        if (rent == null)
        {
            Console.WriteLine("BŁĄD: Nie znaleziono takiego wypożyczenia w systemie.");
            return;
        }
        rent.ReturnDate = DateTime.Now;
        rent.RentedDevice.IsAvailable = true;

        var returnDate = rent.ReturnDate.Value.Date;
        var plannedReturnDate = rent.DueToDate.Date;
        if (returnDate <= plannedReturnDate)
        {
            rent.ReturnFee = 0;
            Console.WriteLine("Sprzęt został oddany w terminie");
        }
        else
        {
            int daysAfterDeadline = (returnDate - plannedReturnDate).Days;
            float fee = daysAfterDeadline * 0.50f;
            rent.ReturnFee = fee;
            Console.WriteLine("Nie oddano przedmiotu w terminie, spóźniono się o: " + daysAfterDeadline);
            Console.WriteLine("Kara wynosi: " + fee + " PLN");
        }
        rentedDevices.Remove(rent);
        rentalHistory.Add(rent);
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

    public void ShowRentedDevices()
    {
        Console.WriteLine("WYPOŻYCZONE SPRZĘTY: ");
        if (rentedDevices.Count == 0)
        {
            Console.WriteLine("Wszystko jest na stanie, nic nie jest wypożyczone");
        }
        var rented =  devicesToRent.Where(d => !d.IsAvailable).ToList();
        foreach (var device in rented)
        {
            Console.WriteLine("- " + device.Name + " " +  device.Model);
        }
    }
    
}