using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AT.Data;
using AT.Models;

namespace AT.Pages.Reserva
{
    public class IndexModel : PageModel
    {
        private readonly AT.Data.ATContext _context;

        public IndexModel(AT.Data.ATContext context)
        {
            _context = context;
        }

        public IList<AT.Models.Reserva> Reserva { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Reserva = await _context.Reservas
                .Include(r => r.Cliente)
                .Include(r => r.PacoteTuristico).ToListAsync();
        }
    }
}
