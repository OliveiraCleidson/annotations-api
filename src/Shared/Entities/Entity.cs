namespace AnnotationApp.Shared.Entities;

public class Entity
{
  public Entity(Guid id, DateTime createdAt, DateTime updatedAt, Guid createdBy, Guid updatedBy)
  {
    Id = id;
    CreatedAt = createdAt;
    UpdatedAt = updatedAt;
    CreatedBy = createdBy;
    UpdatedBy = updatedBy;
  }

  public Entity(Guid createdBy)
  {
    Id = Guid.NewGuid();
    CreatedAt = DateTime.UtcNow;
    UpdatedAt = CreatedAt;
    CreatedBy = createdBy;
    UpdatedBy = CreatedBy;
    DeletedGuid = null;
  }

  public Guid Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public Guid CreatedBy { get; set; }
  public Guid UpdatedBy { get; set; }
  
  public Guid? DeletedGuid { get; set; }
}