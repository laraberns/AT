using AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages
{
    public class CreateClienteModel : PageModel
    {
        [BindProperty]
        public Cliente Cliente { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Console.WriteLine($"Cliente cadastrado: Nome = {Cliente.Nome}, Email = {Cliente.Email}");

            TempData["MensagemSucesso"] = $"Cliente '{Cliente.Nome}' cadastrado com sucesso!";
            return RedirectToPage();
        }
    }
}
