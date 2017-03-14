using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_empty.Controllers
{
    [Route("[controller]")]
    public sealed class HelloController : Controller
    {
        [HttpGet("")]
        public string Get()
        {
            return "Hello world!";
        }
    }
}