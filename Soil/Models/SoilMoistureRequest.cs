namespace Soil.Models;

public class SoilMoistureRequest
{
    public string Type { get; set; }
    public Params Params { get; set; }
    public string Reference { get; set; }
    public List<string> Sensors { get; set; }
    public int Limit { get; set; }

    public SoilMoistureRequest()
    {
        Type = "mt_stats";
        Params = new Params();
        Sensors = new List<string> { "soilmoisture" };
        Limit = 10;
    }
}