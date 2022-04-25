using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _extensionContentTypeProvider;

        public FilesController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _extensionContentTypeProvider = fileExtensionContentTypeProvider ?? throw new ArgumentNullException(nameof(fileExtensionContentTypeProvider));
        }

        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileId) 
        {
            var pathToFile = "13065133.pdf";

            if(!System.IO.File.Exists(pathToFile))
                return NotFound();

            if (!_extensionContentTypeProvider.TryGetContentType(pathToFile, out var contentType))
                contentType = "application/octet-stream";


            var bytes = System.IO.File.ReadAllBytes(pathToFile);    
            return File(bytes, contentType, Path.GetFileName(pathToFile));

        }
    }
}
