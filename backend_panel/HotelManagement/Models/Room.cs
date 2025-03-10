namespace HotelManagement.Models;
public class Room
{
    public int RoomId { get; set; }
    public int HotelId { get; set; }
    public string RoomType { get; set; } = null!;
}
