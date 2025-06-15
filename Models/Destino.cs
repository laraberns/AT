using System.ComponentModel.DataAnnotations;

namespace AT.Models
{
    public class Destino
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da cidade é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome da cidade deve ter no mínimo 3 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O país é obrigatório.")]
        public string Pais { get; set; }
    }
}
