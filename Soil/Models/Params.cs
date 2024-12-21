namespace Soil.Models;

public class Params
{
    public string BmType { get; set; } = "soilmoisture";
    public string DateStart { get; set; }
    public string DateEnd { get; set; }
    public Geometry Geometry { get; set; }
    public string Reference { get; set; }
    public List<string> Sensors { get; set; }
    public int Limit { get; set; }
}