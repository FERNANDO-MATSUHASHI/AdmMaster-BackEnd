using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites
{
    public class Veiculo
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor_saida { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor_km { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal adicional_noturno { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal hora_parada { get; set; }
        public string descricao { get; set; }
        public int Tipo_ServicoId { get; set; }
        public Tipo_Servico? Tipo_Servico { get; set; }
        public int Tipo_VeiculoId { get; set; }
        public Tipo_Veiculo? Tipo_Veiculo { get; set; }

    }
}