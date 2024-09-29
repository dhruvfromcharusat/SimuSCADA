using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuSCADA.Application.Models;

public enum DeviceType
{
    /// <summary>
    /// Simulate environments like HVAC systems, industrial processes, etc.
    /// </summary>
    Temprature,

    /// <summary>
    /// Useful in industrial applications, pipelines, and fluid dynamics.
    /// </summary>
    Pressure,

    /// <summary>
    /// Common in liquid or gas flow monitoring systems.
    /// </summary>
    Flow,

    /// <summary>
    /// Typically used in robotics, automation, and industrial machinery.
    /// </summary>
    Proximity,

    /// <summary>
    /// Can simulate conditions like wear and tear in mechanical systems.
    /// </summary>
    Vibration,

    /// <summary>
    /// Simulate the level of liquids in tanks, reservoirs, etc.
    /// </summary>
    Level,

    /// <summary>
    /// Useful for simulating electrical systems and detecting fluctuations in voltage.
    /// </summary>
    Voltage,

    /// <summary>
    /// Can simulate agricultural or climate-controlled environments.
    /// </summary>
    Humidity,
}
