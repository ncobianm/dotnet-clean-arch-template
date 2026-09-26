using CleanArch.Api.Common.Errors;
using CleanArch.Application;
using CleanArch.Infrastructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    // Add application services
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);
    
    builder.Services.AddControllers();
    
    // Add a custom ProblemDetailsFactory to handle exceptions and return standardized error responses
    builder.Services.AddSingleton<ProblemDetailsFactory, CleanArchProblemDetailsFactory>();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}