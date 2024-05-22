using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class FileEntities
{
    [Key]
    public string FileName { get; set; } = null!;
    public string? ContentType { get; set; }
    public string? ContainerName { get; set; }
}
