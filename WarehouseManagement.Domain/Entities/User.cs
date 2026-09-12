namespace WarehouseManagement.Domain.Entities;

public class User : BaseEntity
{
    
    public string Username { get; set; }
    
    public string Email { get; set; }
    
    public string Password { get; set; }
    
    public string HashPassword { get; set; }
    
    public bool isActive { get; set; }
    
    public ICollection<UserRoles>  UserRoles { get; set; }
}