namespace WarehouseManagement.Domain.Entities;

public class Role : BaseEntity
{
   public required string Name { get; set; }
   
   ICollection<UserRoles>   UserRoles { get; set; }
}