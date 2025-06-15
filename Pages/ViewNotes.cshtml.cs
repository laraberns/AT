using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Text;

public class ViewNotesModel : PageModel
{
    public List<FileInfo> NotesFiles { get; set; } = new List<FileInfo>();
    public string SelectedFileName { get; set; }
    public string SelectedFileContent { get; set; }

    public void OnGet(string file)
    {
        var filesDir = Path.Combine("wwwroot", "files");
        if (Directory.Exists(filesDir))
        {
            NotesFiles = new DirectoryInfo(filesDir).GetFiles("*.txt").ToList();
        }

        if (!string.IsNullOrEmpty(file))
        {
            SelectedFileName = file;
            var filePath = Path.Combine(filesDir, file);
            if (System.IO.File.Exists(filePath))
            {
                SelectedFileContent = System.IO.File.ReadAllText(filePath, Encoding.UTF8);
            }
        }
    }

    public IActionResult OnPost(string FileName, string Content)
    {
        var safeName = Path.GetFileNameWithoutExtension(FileName) + ".txt";
        safeName = string.Concat(safeName.Split(Path.GetInvalidFileNameChars()));

        var filePath = Path.Combine("wwwroot", "files", safeName);
        Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        System.IO.File.WriteAllText(filePath, Content, Encoding.UTF8);

        return RedirectToPage(new { file = safeName });
    }
}