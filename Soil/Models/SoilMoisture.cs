namespace Soil.Models;

public class SoilMoisture
{
    public string SceneId { get; init; }  
    public string ViewId { get; init; }
    public DateTime Date { get; init; }
    public double Average { get; init; }  
    public double? Min { get; init; }      
    public double? Max { get; init; }        
    public string Unit { get; init; }      

}