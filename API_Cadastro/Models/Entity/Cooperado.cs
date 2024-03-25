using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Cadastro.Models.Entity
{
    public class Cooperado
    {
        [Key]
        public required int Id { get; set; }

        public required string Nome { get; set; }

        public required string Telefone { get; set; }

        public required string Email { get; set; }

        public bool Ativo { get; set; }

    }
}
