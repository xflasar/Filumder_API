using Filumder_API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Filumder_API.Controllers
{
    [ApiController]
    [Route("api/File")]
    public class FileItemController : Controller
    {
        private readonly ILogger<FileItemController> _logger;

        public FileItemController(ILogger<FileItemController> logger)
        {
            _logger = logger;
        }

        [HttpGet("DownloadFile")]
        public IActionResult DownloadFile()
        {
            // Replace "external_file_url" with the actual URL of the file
            var externalFileUrl = "https://example.com/path/to/file.ext";
            return Ok(new { Url = externalFileUrl, _fileItem = new FileItem("TestName", "TestDescription", "TestURL") });
        }
    }
}
