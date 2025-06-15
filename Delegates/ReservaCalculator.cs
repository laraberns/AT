namespace AT.Delegates
{
    public class ReservaCalculator
    {
        public Func<int, int, decimal> CalcularValorTotal = (numeroDiarias, valorDiaria) =>
        {
            return numeroDiarias * valorDiaria;
        };
    }
}
