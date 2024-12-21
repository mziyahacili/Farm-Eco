namespace Soil.DTOs;

public record GeometryDTO
    (string type, List<List<double[]>> coordinates);