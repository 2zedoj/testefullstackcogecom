using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Cadastro.Models.Entity
{
    public class UnidadeConsumidora
    {
        [Key]
        public int Id { get; set; }

        public required string Codigo { get; set; }

        public required int Concessionaria { get; set; }

        public required bool Ativo { get; set; }

        public required int UF { get; set; }


        [ForeignKey("Cooperado")]
        public required int CooperadoId { get; set; }

        [ForeignKey("Endereco")]
        public required int EnderecoId { get; set; }

        public required Cooperado Cooperado { get; set; }

        public required Endereco Endereco { get; set; }
    }
}
