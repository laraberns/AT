using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AT.Data;
using AT.Models;
using Microsoft.AspNetCore.Authorization;

namespace AT.Pages.Destino
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly AT.Data.ATContext _context;

        public CreateModel(AT.Data.ATContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AT.Models.Destino Destino { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            _context.Destinos.Add(Destino);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
