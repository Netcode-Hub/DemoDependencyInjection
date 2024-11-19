using DemoDependencyInjection.Interfaces;
using DemoDependencyInjection.Service;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddKeyedSingleton<IShippingService,StandardShipping>("Standard");
builder.Services.AddKeyedSingleton<IShippingService, ExpressShipping>("Express");
builder.Services.AddKeyedSingleton<IShippingService, InternationalShipping>("International");

//builder.Services.AddSingleton<Func<string, IShippingService>>(provider => key =>
//{
//    return key switch
//    {
//        "Standard" => provider.GetRequiredService<StandardShipping>(),
//        "Express" => provider.GetRequiredService<ExpressShipping>(),
//        "International" => provider.GetRequiredService<InternationalShipping>(),
//        _ => throw new KeyNotFoundException($"No shipping service registered for key '{key}'")
//    };
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
