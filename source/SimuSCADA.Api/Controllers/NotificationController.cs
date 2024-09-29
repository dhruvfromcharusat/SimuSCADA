using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SimuSCADA.Api.Controllers;

[ApiController]
[Route("api/v1/notification")]
public class NotificationController : ControllerBase
{
    private readonly IMediator _mediator;

    public NotificationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("email")]
    public async Task<IActionResult> GetEmailNotification()
    {
        return Ok();
    }

    [HttpGet("email/{SubscriptionId}")]
    public async Task<IActionResult> GetEmailNotificationById(Guid SubscriptionId, [FromQuery] string? email)
    {
        return Ok();
    }

    [HttpPost("email")]
    public async Task<IActionResult> SubscribeEmailNotification()
    {
        return Ok();
    }

    [HttpDelete("email/{SubscriptionId}")]
    public async Task<IActionResult> UnsubscribeEmailNotification(Guid SubscriptionId)
    {
        return Ok();
    }
}
