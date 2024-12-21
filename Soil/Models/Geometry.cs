namespace Soil.Models;

public class Geometry
{
    public string Type { get; set; } = "Polygon";
    public List<List<List<double>>> Coordinates { get; set; }
}