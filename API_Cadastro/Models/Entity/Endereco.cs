using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Cadastro.Models.Entity
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }

        public required string Logradouro { get; set; }

        public required string Bairro { get; set; }

        public required string Localidade { get; set; }

        public required string UF { get; set; }

        public required string numero { get; set; }

    }
}
