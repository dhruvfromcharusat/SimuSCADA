using MediatR;
using SimuSCADA.Data.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuSCADA.Application.Device.Query;

public class GetDevicesQueryHandler(IRepository<Models.Device> repository) : IRequestHandler<GetDevicesQuery, List<Models.Device>>
{
    private readonly IRepository<Models.Device> _deviceRepository = repository;

    public async Task<List<Models.Device>> Handle(GetDevicesQuery request, CancellationToken cancellationToken)
    {
        return await _deviceRepository.GetAll().ConfigureAwait(false) ?? [];
    }
}
