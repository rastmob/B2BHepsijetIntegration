using Microsoft.AspNetCore.Mvc;
using B2BHepsijetIntegration.Application.Interfaces;

namespace B2BHepsijetIntegration.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IHepsijetAuthService _authService;

    public AuthController(IHepsijetAuthService authService)
    {
        _authService = authService;
    }

    [HttpGet("get-token")]
    public async Task<IActionResult> GetToken([FromQuery] string username, [FromQuery] string password)
    {
        var token = await _authService.GetTokenAsync(username, password);
        return Ok(new { token });
    }
}
