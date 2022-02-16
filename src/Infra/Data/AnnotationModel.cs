using System.ComponentModel.DataAnnotations.Schema;

namespace AnnotationApp.Infra.Data;

public class AnnotationModel
{
    [Column("ANNOTATION_ID")]
    public Guid Id { get; set; }
}