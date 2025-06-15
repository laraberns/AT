using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AT.Data;
using AT.Models;

namespace AT.Pages.PacoteDestino
{
    public class EditModel : PageModel
    {
        private readonly AT.Data.ATContext _context;

        public EditModel(AT.Data.ATContext context)
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

            var pacotedestino =  await _context.PacoteDestinos.FirstOrDefaultAsync(m => m.PacoteTuristicoId == id);
            if (pacotedestino == null)
            {
                return NotFound();
            }
            PacoteDestino = pacotedestino;
           ViewData["DestinoId"] = new SelectList(_context.Destinos, "Id", "Nome");
           ViewData["PacoteTuristicoId"] = new SelectList(_context.PacotesTuristicos, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            _context.Attach(PacoteDestino).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PacoteDestinoExists(PacoteDestino.PacoteTuristicoId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PacoteDestinoExists(int id)
        {
            return _context.PacoteDestinos.Any(e => e.PacoteTuristicoId == id);
        }
    }
}
