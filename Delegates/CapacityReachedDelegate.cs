using AT.Models;

namespace AT.Delegates
{
    public class CapacityReachedDelegate
    {
        static void Main(string[] args)
        {
            PacoteTuristico pacote = new PacoteTuristico
            {
                Id = 1,
                Titulo = "Pacote Paris",
                DataInicio = DateTime.Now.AddDays(30),
                CapacidadeMaxima = 3,
                Preco = 5000,
                Destinos = new List<Destino>()
            };

            pacote.CapacityReached += RegistrarAlerta;

            pacote.AdicionarReserva(); 
            pacote.AdicionarReserva(); 
            pacote.AdicionarReserva(); 
            pacote.AdicionarReserva(); 
        }

        static void RegistrarAlerta(object sender, string mensagem)
        {
            Console.WriteLine($"ALERTA ATINGIDO {mensagem}");
        }
    }
}
