using System.ComponentModel.DataAnnotations;

namespace AT.Models
{
    public class Cliente
    {
        //public int Id { get; set; }

        //[Required(ErrorMessage = "O nome é obrigatório.")]
        //[MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres.")]
        //[StringLength(100, ErrorMessage = "O nome não pode ter mais que 100 caracteres.")]
        //public string Nome { get; set; }

        //[Required(ErrorMessage = "O e-mail é obrigatório.")]
        //[EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
        //public string Email { get; set; }
        //public List<Reserva> Reservas { get; set; }


        // Exercicio 10
        public int Id { get; set; }

        [Required, MinLength(3), StringLength(100)]
        public string Nome { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public List<Reserva> Reservas { get; set; }

        // Exercicio 12a
        public bool IsDeleted { get; set; }
    }
}
