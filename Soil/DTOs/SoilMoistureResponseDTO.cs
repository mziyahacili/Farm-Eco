namespace Soil.DTOs;

public record SoilMoistureResponseDTO
{
    public List<ResultDTO> Result { get; init; }
}
