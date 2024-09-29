using SimuSCADA.Data.Options;

namespace SimuSCADA.Api.Utilities;

public static class OptionConfiguration
{
    public static void ConfigureOptions(this IHostApplicationBuilder builder)
    {
        var config = builder.Configuration;
        builder.Services.Configure<MongoDatabaseOptions>(builder.Configuration.GetSection("MongoDb"));
    }
}