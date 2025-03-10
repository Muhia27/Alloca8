namespace HotelManagement.Models;
public class Booking
{
    public int BookingId { get; set; }
    public int UserId { get; set; }
    public int RoomId { get; set; }
    public DateTime BookingDate { get; set; }
}
