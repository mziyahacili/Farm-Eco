using Soil.Controllers;
using Soil.DTOs;
using Soil.Models;

namespace Soil.Services.Interfaces;

public interface ISoilMoistureService
{
  
    Task<SoilMoistureResponse> CreateSoilMoistureTaskAsync(SoilMoistureRequest request);
  
    Task<List<SoilMoistureDTO>> GetSoilMoistureResultAsync(string taskId);
}