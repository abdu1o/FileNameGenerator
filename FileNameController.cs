using Microsoft.AspNetCore.Mvc;

namespace FileNameGenerator
{
    public class FileNameController : Controller
    {
        private readonly FileNameGeneratorService _fileNameGeneratorService;

        public FileNameController(FileNameGeneratorService fileNameGeneratorService)
        {
            _fileNameGeneratorService = fileNameGeneratorService;
        }

        [HttpGet("/generate-filename/{length:int}")]
        public IActionResult GenerateFileName(int length)
        {
            if (length <= 0)
            {
                Console.WriteLine("Length must be greater than 0");
            }

            string generatedFileName = _fileNameGeneratorService.GenerateFileName(length);
            return Ok(new { fileName = generatedFileName });
        }
    }
}
