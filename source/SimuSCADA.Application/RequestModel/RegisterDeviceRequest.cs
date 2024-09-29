using SimuSCADA.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuSCADA.Application.RequestModel;

public record RegisterDeviceRequest(DeviceType Type, string HostName, string SearialNumber, string Csr, DateTime CreatedAt);