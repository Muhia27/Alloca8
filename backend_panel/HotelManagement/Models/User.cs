using System.ComponentModel.DataAnnotations.Schema;
namespace HotelManagement.Models; // ✅ Correct namespace

public class User
{
    public int Id { get; set; } // Use "Id" instead of "UserId" (or configure EF Core)
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
}