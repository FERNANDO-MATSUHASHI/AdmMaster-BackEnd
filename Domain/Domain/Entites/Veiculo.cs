using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites
{
    public class Veiculo
    {
        public int tipo_veiculo_ID { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor_saida { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor_km { get; set; }
        public List<Tipo_Veiculo>? Tipo_Veiculos { get; set; }
    }
}