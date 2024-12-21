namespace Soil.Models;

public class SoilMoistureRequest
{
    public string Type { get; set; } = "mt_stats";
    public Params Params { get; set; }
}