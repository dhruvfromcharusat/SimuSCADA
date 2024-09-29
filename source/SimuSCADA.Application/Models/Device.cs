using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuSCADA.Application.Models;

public record Device(Guid Id, DeviceType Type, string HostName, string SearialNumber, string Csr, DateTime CreatedAt, DateTime? Lastupdated, string? FingerPrint = null, string? Certificate = null);