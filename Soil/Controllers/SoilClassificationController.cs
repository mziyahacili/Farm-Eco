using Microsoft.AspNetCore.Mvc;
using Soil.Services.Classes;
using Soil.Services.Interfaces;

namespace Soil.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SoilClassificationController : ControllerBase
{
    private readonly ISoilGridsService _soilGridsService;

    public SoilClassificationController(ISoilGridsService soilGridsService)
    {
        _soilGridsService = soilGridsService;
    }

    [HttpGet("classification")]
    public async Task<IActionResult> GetClassification(double longitude, double latitude, int numberClasses = 5)
    {
        if (numberClasses < 1 || numberClasses > 10)
            return BadRequest("Number of classes must be between 1 and 10.");

        try
        {
            var result = await _soilGridsService.GetClassificationDataAsync(longitude, latitude, numberClasses);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An error occurred: {ex.Message}");
        }
    }
}
