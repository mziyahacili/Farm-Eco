namespace Soil.DTOs;

public record SoilMoistureDTO
{
    public string Date { get; set; }
    public double? SurfaceMoisture { get; set; }  
    public double? RootZoneMoisture { get; set; }  
}

