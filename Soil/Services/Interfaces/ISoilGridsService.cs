using Soil.Models;

namespace Soil.Services.Interfaces;

public interface ISoilGridsService
{
    public Task<SoilClassificationResponse> GetClassificationDataAsync(double longitude, double latitude,
        int numberClasses);
}