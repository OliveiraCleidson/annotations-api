using AnnotationApp.Shared.Entities;

namespace Domain.Entities;

public class Annotation : Entity
{
    public Annotation(string title, string content, Guid createdBy) :base(createdBy)
    {     
        Title = title;
        Content = content;
    }
    public string Title { get; set; }
    public string Content { get; set; }
}