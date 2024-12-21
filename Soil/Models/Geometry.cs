namespace Soil.Models;

public class Geometry
{
    public string Type { get; set; }
    public List<List<double[]>> Coordinates { get; set; }

    public Geometry()
    {
        Type = "Polygon";
        Coordinates = new List<List<double[]>>();
    }
}