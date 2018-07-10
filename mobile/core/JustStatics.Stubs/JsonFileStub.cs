using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using System.IO;

namespace JustStatics.Stubs
{
    public static class JsonFileStub
    {
        [FunctionName("JsonFileStub")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "JustStatics/stub/{fileName?}")] HttpRequest req,
            TraceWriter log,
            string fileName)
        {
            log.Info($"HTTP Trigger executed for filename '{fileName}'...");

            return new OkObjectResult(File.ReadAllText($"./Responses/{fileName}")) as ActionResult;
        }
    }
}