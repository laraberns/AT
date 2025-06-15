using AT.Delegates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages
{
    public class ReservaCalculatorModel : PageModel
    {
        [BindProperty]
        public int NumeroDiarias { get; set; }

        [BindProperty]
        public int ValorDiaria { get; set; }

        public decimal ValorTotal { get; set; }

        public void OnPost()
        {
            var calculadora = new ReservaCalculator();

            ValorTotal = calculadora.CalcularValorTotal(NumeroDiarias, ValorDiaria);
        }
    }
}
