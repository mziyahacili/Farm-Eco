using Soil.DTOs;
using Soil.Models;
using Soil.Services.Interfaces;

namespace Soil.Services.Classes;

using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using System.Collections.Generic;

public class SoilMoistureService : ISoilMoistureService
{
    private readonly HttpClient _httpClient;
    private readonly IMapper _mapper;
    private readonly string _apiKey;

    public SoilMoistureService(HttpClient httpClient, IMapper mapper, string apiKey, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _mapper = mapper;
        _apiKey = configuration["EosdaApi:Key"]; 
    }

    
    public async Task<List<SoilMoistureDTO>> GetSoilMoistureAsync(SoilMoistureRequest request)
    {
        var uri = "https://api-connect.eos.com/api/gdw/api?api_key=" + _apiKey;

        var jsonRequest = JsonSerializer.Serialize(request);
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(uri, content);
        
        if (response.IsSuccessStatusCode)
        {
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var soilMoistureResponse = JsonSerializer.Deserialize<SoilMoistureResponse>(jsonResponse);
            
            return _mapper.Map<List<SoilMoistureDTO>>(soilMoistureResponse.Result);
        }

        throw new HttpRequestException("Error retrieving soil moisture data.");
    }

    public async Task<List<SoilMoistureDTO>> GetSoilMoistureResultAsync(string taskId)
    {
        var uri = $"https://api-connect.eos.com/api/gdw/api/{taskId}?api_key={_apiKey}";

        var response = await _httpClient.GetAsync(uri);

        if (response.IsSuccessStatusCode)
        {
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var soilMoistureResponse = JsonSerializer.Deserialize<SoilMoistureResponse>(jsonResponse);
            
            return _mapper.Map<List<SoilMoistureDTO>>(soilMoistureResponse.Result);
        }

        throw new HttpRequestException("Error retrieving soil moisture result.");
    }
}
