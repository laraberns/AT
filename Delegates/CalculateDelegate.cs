using System;

namespace AT.Delegates
{

    public delegate double CalculateDiscount(double valor);

    public class DiscountCalculator
    {
        public static double CalculateDiscountMethod(double valor)
        {
            return valor * 0.9;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço original de uma diária: ");

            if (double.TryParse(Console.ReadLine(), out double precoDiaria))
            {
                CalculateDiscount handler = DiscountCalculator.CalculateDiscountMethod;

                double precoComDesconto = handler(precoDiaria);

                Console.WriteLine($"O preço com desconto da diária é: R$ {precoComDesconto:F2}");
            }
            else
            {
                Console.WriteLine("Valor inválido! Por favor, digite um número.");
            }
        }
    }
}
