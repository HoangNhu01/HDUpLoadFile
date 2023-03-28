using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace UpLoadFile.Controllers
{
    public class UpLoadFileController : Controller
    {
        private readonly ILogger<UpLoadFileController> _logger;
        private readonly IHostingEnvironment _environment;

        public UpLoadFileController(ILogger<UpLoadFileController> logger, IHostingEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> UploadAsync(IFormFile file1)
        {
            // save vao 1 folder hoac db 
            return Ok();
        }
    }
}
