namespace Soil.Models;

public class Params
{
    public string BmType { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public Geometry Geometry { get; set; }

    public Params()
    {
        BmType = "soilmoisture";
        Geometry = new Geometry();
    }
}