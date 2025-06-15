using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AT.Data;
using AT.Models;
using Microsoft.AspNetCore.Authorization;

namespace AT.Pages.PacoteDestino
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly AT.Data.ATContext _context;

        public DeleteModel(AT.Data.ATContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AT.Models.PacoteDestino PacoteDestino { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacotedestino = await _context.PacoteDestinos.FirstOrDefaultAsync(m => m.PacoteTuristicoId == id);

            if (pacotedestino == null)
            {
                return NotFound();
            }
            else
            {
                PacoteDestino = pacotedestino;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacotedestino = await _context.PacoteDestinos.FindAsync(id);
            if (pacotedestino != null)
            {
                PacoteDestino = pacotedestino;
                _context.PacoteDestinos.Remove(PacoteDestino);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
