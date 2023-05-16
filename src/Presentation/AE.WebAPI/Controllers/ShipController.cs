using Microsoft.AspNetCore.Mvc;

namespace AE.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShipController : ControllerBase
{
    private readonly ILogger<ShipController> _logger;

    public ShipController(ILogger<ShipController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllShips()
    {
        return Ok(await Task.FromResult(string.Empty));
    }

    [HttpPost]
    public async Task<IActionResult> GetShipById(Guid shipId)
    {
        return Ok(await Task.FromResult(string.Empty));
    }

    [HttpPut]
    public async Task<IActionResult> EditShipById(Guid shipId)
    {
        return Ok(await Task.FromResult(string.Empty));
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteShipById(Guid shipId)
    {
        return Ok(await Task.FromResult(string.Empty));
    }
}
