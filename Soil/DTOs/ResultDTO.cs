namespace Soil.DTOs;

public record ResultDTO
{
    public string SceneId { get; init; }
    public string ViewId { get; init; }
    public DateTime Date { get; init; }
    public double Average { get; init; }
}
