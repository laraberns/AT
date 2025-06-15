using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AT.Data;
using AT.Models;

namespace AT.Pages.PacoteDestino
{
    public class CreateModel : PageModel
    {
        private readonly AT.Data.ATContext _context;

        public CreateModel(AT.Data.ATContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DestinoId"] = new SelectList(_context.Destinos, "Id", "Nome");
        ViewData["PacoteTuristicoId"] = new SelectList(_context.PacotesTuristicos, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public AT.Models.PacoteDestino PacoteDestino { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            _context.PacoteDestinos.Add(PacoteDestino);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
