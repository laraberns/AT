namespace AT.Models
{
    public class PacoteDestino
    {

        // Exercicio 10
        public int PacoteTuristicoId { get; set; }
        public PacoteTuristico PacoteTuristico { get; set; }

        public int DestinoId { get; set; }
        public Destino Destino { get; set; }
    }
}
