using Microsoft.AspNetCore.Mvc;
using B2BHepsijetIntegration.Application.Interfaces;
using B2BHepsijetIntegration.Domain.Models;

namespace B2BHepsijetIntegration.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DeliveryController : ControllerBase
{
    private readonly IHepsijetDeliveryService _deliveryService;

    public DeliveryController(IHepsijetDeliveryService deliveryService)
    {
        _deliveryService = deliveryService;
    }

    [HttpPost("send-advance")]
    public async Task<IActionResult> SendAdvance([FromBody] DeliveryAdvanceRequest request, [FromHeader(Name = "X-Auth-Token")] string token)
    {
        var result = await _deliveryService.SendDeliveryAdvanceAsync(request, token);
        return Ok(result);
    }
}
