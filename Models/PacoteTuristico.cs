namespace AT.Models
{
    public class PacoteTuristico
    {
        //public int Id { get; set; }
        //public string Titulo { get; set; }
        //public DateTime DataInicio { get; set; }
        //public int CapacidadeMaxima { get; set; }
        //public decimal Preco { get; set; }
        //public List<Destino> Destinos { get; set; }

        //public int NumeroReservas { get; private set; } = 0;

        //public event EventHandler<string> CapacityReached;

        //public void AdicionarReserva()
        //{
        //    NumeroReservas++;
        //    Console.WriteLine($"Reserva adicionada. Total de reservas: {NumeroReservas}");

        //    if (NumeroReservas > CapacidadeMaxima)
        //    {
        //        OnCapacityReached();
        //    }
        //}

        //protected virtual void OnCapacityReached()
        //{
        //    CapacityReached?.Invoke(this, $"Capacidade máxima de '{Titulo}' foi excedida! ({NumeroReservas}/{CapacidadeMaxima})");
        //}

        // Exercicio 10
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataInicio { get; set; }
        public int CapacidadeMaxima { get; set; }
        public decimal Preco { get; set; }

        public List<PacoteDestino> PacoteDestinos { get; set; }

        public List<Reserva> Reservas { get; set; }

    }
}
