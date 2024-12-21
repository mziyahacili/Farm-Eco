using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Soil.Models;
using Soil.Services.Interfaces;

namespace Soil.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SoilMoistureController : ControllerBase
{
    private readonly ISoilMoistureService _soilMoistureService;

    public SoilMoistureController(ISoilMoistureService soilMoistureService)
    {
        _soilMoistureService = soilMoistureService;
    }

    [HttpPost("get-soil-moisture")]
    public async Task<IActionResult> GetSoilMoisture([FromBody] SoilMoistureRequest request)
    {
        try
        {
            var soilMoisters = await _soilMoistureService.GetSoilMoistureAsync(request);
            return Ok(soilMoisters);
        }
        catch (HttpRequestException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("get-soil-moisture-result/{taskId}")]
    public async Task<IActionResult> GetSoilMoistureResult(string taskId)
    {
        try
        {
            var soilMoisters = await _soilMoistureService.GetSoilMoistureResultAsync(taskId);
            return Ok(soilMoisters);
        }
        catch (HttpRequestException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

