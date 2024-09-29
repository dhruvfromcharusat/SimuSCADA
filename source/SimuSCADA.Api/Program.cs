using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using SimuSCADA.Api;
using SimuSCADA.Api.Utilities;
using SimuSCADA.Application.Device.Command;
using SimuSCADA.Data;
using System.Reflection;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOptions();

builder.ConfigureOptions();

ConfigureDependency(builder.Services);
ConfigureMediatR(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static void ConfigureDependency(IServiceCollection services)
{
    services.ConfigureDataDependency();
}

static void ConfigureMediatR(IServiceCollection services)
{
    services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(
        Assembly.GetExecutingAssembly(),
        typeof(RegisterDeviceHandler).Assembly
    ));

    services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
    services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
}