using System.ComponentModel.DataAnnotations;

namespace AT.Models
{
    public class Destino
    {
        //public int Id { get; set; }

        //[Required(ErrorMessage = "O nome da cidade é obrigatório.")]
        //[MinLength(3, ErrorMessage = "O nome da cidade deve ter no mínimo 3 caracteres.")]
        //public string Nome { get; set; }

        //[Required(ErrorMessage = "O país é obrigatório.")]
        //public string Pais { get; set; }

        // Exercicio 10
        public int Id { get; set; }

        [Required, MinLength(3)]
        public string Nome { get; set; }

        [Required]
        public string Pais { get; set; }

        public List<PacoteDestino> PacoteDestinos { get; set; }

    }
}
