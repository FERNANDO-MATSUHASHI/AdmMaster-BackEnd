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
        public int Tipo_VeiculoId { get; set; }

        public Tipo_Veiculo? Tipo_Veiculo { get; set; }
        public List<Viatura>? Viaturas { get; set; }
    }
}