using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AT.Data;
using AT.Models;

namespace AT.Pages.PacoteDestino
{
    public class DetailsModel : PageModel
    {
        private readonly AT.Data.ATContext _context;

        public DetailsModel(AT.Data.ATContext context)
        {
            _context = context;
        }

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
    }
}
