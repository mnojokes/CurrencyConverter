using CurrencyConverter.Contracts.Responses;
using CurrencyConverter.Host.Middlewares;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo()
    {
        Title = builder.Configuration.GetValue<string>("SwaggerTitle") ?? string.Empty,
        Description = builder.Configuration.GetValue<string>("SwaggerDescription") ?? string.Empty
    });

    c.ExampleFilters();

    var assemblies = new List<Assembly>
    {
        Assembly.GetExecutingAssembly(), // Include comments from the current assembly
        typeof(ErrorResponse).Assembly,
    };

    foreach (var assembly in assemblies)
    {
        // Set the comments path for the Swagger JSON and UI.
        var xmlFile = $"{assembly.GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        if (File.Exists(xmlPath))
        {
            c.IncludeXmlComments(xmlPath);
        }
    }
});

builder.Services.AddSwaggerExamplesFromAssemblyOf<Program>();

builder.Services.AddApplication();
builder.Services.AddInfrastructure();

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

app.UseExceptionHandlingMiddleware();

app.Run();
