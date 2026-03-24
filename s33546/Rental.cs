namespace s33546;

public class Rental
{
    public User RentedTo { get; set; }
    public Device RentedDevice { get; set; }
    public DateTime RentedDate { get; set; }
    public DateTime DueToDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public float ReturnFee { get; set; }
    
    public Rental (User user, Device device, DateTime date,  DateTime dueToDate)
    {
        RentedTo = user;
        RentedDevice = device;
        RentedDate = date;
        DueToDate = dueToDate;
    }
}