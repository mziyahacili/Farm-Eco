using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Soil.Models;
using Soil.Services.Interfaces;

namespace Soil.Controllers;

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class SoilMoistureController : ControllerBase
{
    private readonly ISoilMoistureService _soilMoistureService;

    public SoilMoistureController(ISoilMoistureService soilMoistureService)
    {
        _soilMoistureService = soilMoistureService;
    }

    [HttpPost("create-task")]
    public async Task<IActionResult> CreateTask([FromBody] SoilMoistureRequest request)
    {
        try
        {
            var taskId = await _soilMoistureService.CreateSoilMoistureTaskAsync(request);
            return Ok(new { TaskId = taskId });
        }
        catch (HttpRequestException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("get-result/{taskId}")]
    public async Task<IActionResult> GetResult(string taskId)
    {
        try
        {
            var results = await _soilMoistureService.GetSoilMoistureResultAsync(taskId);
            return Ok(results);
        }
        catch (HttpRequestException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

