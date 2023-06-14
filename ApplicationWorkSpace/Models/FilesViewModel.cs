using Microsoft.AspNetCore.Mvc.RazorPages;


namespace ApplicationWorkSpace.Models
{
    public class FilesViewModel : PageModel
    {
        public List<FileDetails> Files { get; set; }
          = new List<FileDetails>();
    }

    public class FileDetails
    {
        public string? Name { get; set; }
        public string? Path { get; set; }

    }
}
