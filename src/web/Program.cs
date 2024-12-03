using Microsoft.Azure.Functions.Worker.Builder; // Provides FunctionsApplication
using Microsoft.Extensions.Hosting; // Gives the builder.Build() a .Run() method

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

builder.Build().Run();