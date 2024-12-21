namespace Soil.DTOs;

public record SoilMoistureRequestDTO
{
    public string Type { get; init; } = "mt_stats";
    public ParamsDTO Params { get; init; } = new ParamsDTO();
    public string Reference { get; init; }
    public List<string> Sensors { get; init; } = new List<string> { "soilmoisture" };
    public int Limit { get; init; } = 10;
}
