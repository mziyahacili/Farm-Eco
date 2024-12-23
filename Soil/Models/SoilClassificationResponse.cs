namespace Soil.Models;

public class SoilClassificationResponse
{
    public string Type { get; set; }
    public List<double> Coordinates { get; set; }
    public double QueryTimeS { get; set; }
    public string WrbClassName { get; set; }
    public int WrbClassValue { get; set; }
    public List<WrbClassProbability> WrbClassProbability { get; set; }
}