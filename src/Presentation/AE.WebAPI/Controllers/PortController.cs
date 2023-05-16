using Microsoft.AspNetCore.Mvc;

namespace AE.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PortController : ControllerBase
{
    private readonly ILogger<PortController> _logger;

    public PortController(ILogger<PortController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetClosestPortAndEstimatedArrivalTime()
    {
        return Ok(await Task.FromResult(string.Empty));
    }
}
