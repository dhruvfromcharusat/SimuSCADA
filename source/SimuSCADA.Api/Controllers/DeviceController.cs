using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SimuSCADA.Application.Device;
using SimuSCADA.Application.Device.Command;
using SimuSCADA.Application.Device.Query;
using SimuSCADA.Application.Models;
using SimuSCADA.Application.RequestModel;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace SimuSCADA.Api.Controllers;

[ApiController]
[Route("api/v1/devices")]
public class DeviceController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    public async Task<IActionResult> RegesterDevice(RegisterDeviceRequest request)
    {
        var result = await _mediator.Send(new RegisterDeviceCommand(request.Type, request.HostName, request.SearialNumber, request.Csr, DateTime.UtcNow)).ConfigureAwait(false);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetDevices() 
    {
        var result = await _mediator.Send(new GetDevicesQuery()).ConfigureAwait(false);
        return Ok(result);
    }

    [HttpGet("{deviceId}")]
    public async Task<IActionResult> GetDeviceById(Guid deviceId)
    {
        return Ok();
    }

    [HttpPost("approve")]
    public async Task<IActionResult> DeviceApproval([FromQuery] bool accept)
    {
        return Ok();
    }

    [HttpPatch]
    public async Task<IActionResult> UpdateDeviceConfiguration()
    {
        return Ok();
    }

    [HttpPost("compress/{DeviceId}")]
    public async Task<IActionResult> CompressDeviceData(Guid DeviceId)
    {
        return Ok();
    }
}
