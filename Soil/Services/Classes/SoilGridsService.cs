using Newtonsoft.Json;
using Soil.Models;
using Soil.Services.Interfaces;

namespace Soil.Services.Classes;

public class SoilGridsService : ISoilGridsService
{
    private readonly HttpClient _httpClient;

    public SoilGridsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<SoilClassificationResponse> GetClassificationDataAsync(double longitude, double latitude, int numberClasses)
    {
        var url = $"https://rest.isric.org/soilgrids/v2.0/classification/query?lon={longitude}&lat={latitude}&number_classes={numberClasses}";
        var response = await _httpClient.GetAsync(url);

        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();

        var rawResponse = JsonConvert.DeserializeObject<SoilClassificationResponseRaw>(content);

        return new SoilClassificationResponse
        {
            Type = rawResponse.Type,
            Coordinates = rawResponse.Coordinates,
            QueryTimeS = rawResponse.QueryTimeS,
            WrbClassName = rawResponse.WrbClassName,
            WrbClassValue = rawResponse.WrbClassValue,
            WrbClassProbability = rawResponse.WrbClassProbability?
                .Select(prob => new WrbClassProbability
                {
                    ClassName = prob[0].ToString(),
                    Probability = Convert.ToInt32(prob[1])
                })
                .ToList() ?? new List<WrbClassProbability>()
        };
    }

}