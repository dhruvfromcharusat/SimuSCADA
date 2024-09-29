using MediatR;
using SimuSCADA.Application.Models;
using SimuSCADA.Data.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuSCADA.Application.Device.Command;

public class RegisterDeviceHandler(IRepository<Models.Device> repository) : IRequestHandler<RegisterDeviceCommand, Guid>
{
    private readonly IRepository<Models.Device> _repository = repository;

    public async Task<Guid> Handle(RegisterDeviceCommand request, CancellationToken cancellationToken)
    {
        var model = new Models.Device(Guid.NewGuid(), request.Type, request.HostName, request.SearialNumber, request.Csr, request.CreatedAt, request.CreatedAt);
        await _repository.Create(model).ConfigureAwait(false);
        return model.Id;
    }
}
