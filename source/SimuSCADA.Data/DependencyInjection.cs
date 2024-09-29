using Microsoft.Extensions.DependencyInjection;
using SimuSCADA.Data.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuSCADA.Data;

public static class DependencyInjection
{
    public static void ConfigureDataDependency(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}
