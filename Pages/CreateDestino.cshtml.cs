using System.ComponentModel.DataAnnotations;
using AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages
{
    public class CreateDestinoModel : PageModel
    {
        [BindProperty]
        public Destino Destino { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {

                return Page();
            }

            TempData["MensagemSucesso"] = $"Destino '{Destino.Nome}' cadastrado com sucesso!";
            return RedirectToPage();
        }
    }
}
