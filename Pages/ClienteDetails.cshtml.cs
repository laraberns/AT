using AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages
{
    public class ClienteDetailsModel : PageModel
    {

        private static List<Cliente> clientes = new List<Cliente>
        {
            new Cliente { Id = 1, Nome = "Laura", Email = "laura@gmail.com" },
            new Cliente { Id = 2, Nome = "Geraldo", Email = "geraldo@gmail.com" },
            new Cliente { Id = 3, Nome = "Felipe", Email = "felipe@gmail.com" }
        };

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public Cliente Cliente { get; set; }

        public IActionResult OnGet(int id)
        {
            Cliente = clientes.FirstOrDefault(c => c.Id == id);

            if (Cliente == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
