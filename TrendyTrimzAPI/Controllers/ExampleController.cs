using Microsoft.AspNetCore.Mvc;

namespace TrendyTrimzAPI.Controllers
{
    public class ExampleController : Controller
    {
        [HttpGet("ExampleRoute")]
        public string ExampleRoute()
        {
            return string.Empty;
        }
    }
}
