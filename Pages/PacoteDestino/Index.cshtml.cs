﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly AT.Data.ATContext _context;

        public IndexModel(AT.Data.ATContext context)
        {
            _context = context;
        }

        public IList<AT.Models.PacoteDestino> PacoteDestino { get;set; } = default!;

        public async Task OnGetAsync()
        {
            PacoteDestino = await _context.PacoteDestinos
                .Include(p => p.Destino)
                .Include(p => p.PacoteTuristico).ToListAsync();
        }
    }
}
