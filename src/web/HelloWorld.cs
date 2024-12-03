using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MyCompanyName.MyHelloWorldFunction
{
    public class HelloWorld
    {
        private readonly ILogger<HelloWorld> _logger;

        public HelloWorld(ILogger<HelloWorld> logger)
        {
            _logger = logger;
        }

        [Function("helloWorld")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult($"Hello, {req.Query["name"]}!");
        }
    }
}
