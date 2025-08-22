using BasicShopAPI;
using BasicShopAPI.API.Mapping;
using BasicShopAPI.Application.CQRS.Handlers.Products;
using BasicShopAPI.Domain.Interfaces;
using BasicShopAPI.Infrastructure.Persistence;
using BasicShopAPI.Infrastructure.Repositories;
using FluentMigrator.Runner;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration)
    .AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("name=DefaultConnection", options => options.UseCompatibilityLevel(120)));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
    runner.MigrateUp();
}

app.MapGet("/", () => "Migrations applied");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi("/openapi/v1.json");

    // Swagger UI leyendo el documento nativo
    app.UseSwaggerUI(opt =>
    {
        opt.SwaggerEndpoint("/openapi/v1.json", "BasicShopAPI v1");
        // opcional: servir la UI en /swagger (por defecto ya es /swagger)
        opt.RoutePrefix = "swagger";
    });
}

app.MapControllers();

app.Run();
