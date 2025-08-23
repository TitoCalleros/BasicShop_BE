using BasicShopAPI;
using FluentMigrator.Runner;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration)
    .AddCorsPolicies(builder.Configuration)
    .AddOpenApi()
    .AddControllers();

var app = builder.Build();

app.UseCorsPolicies();

// Configure runner for the migrations
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

    // Swagger configuration    
    app.UseSwaggerUI(opt =>
    {
        opt.SwaggerEndpoint("/openapi/v1.json", "BasicShopAPI v1");        
        opt.RoutePrefix = "swagger";
    });
}

app.MapControllers();

app.Run();
