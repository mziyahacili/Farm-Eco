﻿using Soil.Controllers;
using Soil.DTOs;
using Soil.Models;

namespace Soil.Services.Interfaces;

public interface ISoilMoistureService
{
    Task<List<SoilMoistureDTO>> GetSoilMoistureAsync(SoilMoistureRequest request);
    Task<List<SoilMoistureDTO>> GetSoilMoistureResultAsync(string taskId);
}