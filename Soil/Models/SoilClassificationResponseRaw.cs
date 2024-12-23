using Newtonsoft.Json;

namespace Soil.Models;

public class SoilClassificationResponseRaw
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("coordinates")]
    public List<double> Coordinates { get; set; }

    [JsonProperty("query_time_s")]
    public double QueryTimeS { get; set; }

    [JsonProperty("wrb_class_name")]
    public string WrbClassName { get; set; }

    [JsonProperty("wrb_class_value")]
    public int WrbClassValue { get; set; }

    [JsonProperty("wrb_class_probability")]
    public List<List<object>> WrbClassProbability { get; set; }
}