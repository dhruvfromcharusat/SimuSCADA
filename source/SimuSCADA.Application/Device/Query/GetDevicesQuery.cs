using MediatR;
using SimuSCADA.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimuSCADA.Application.Device.Query;

public record GetDevicesQuery() : IRequest<List<Models.Device>>;