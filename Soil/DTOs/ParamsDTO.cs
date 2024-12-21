namespace Soil.DTOs;

public record ParamsDTO
{
    public string BmType { get; init; }
    public DateTime DateStart { get; init; }
    public DateTime DateEnd { get; init; }
    public GeometryDTO Geometry { get; init; }
}
