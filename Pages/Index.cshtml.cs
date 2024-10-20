using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FileNameGenerator;

namespace FileNameGenerator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FileNameGeneratorService _fileNameGenerator;

        public string GeneratedFileName { get; private set; }

        public IndexModel(FileNameGeneratorService fileNameGenerator)
        {
            _fileNameGenerator = fileNameGenerator;
        }

        public void OnGet(int length = 10)
        {
            GeneratedFileName = _fileNameGenerator.GenerateFileName(length);
        }
    }
}
