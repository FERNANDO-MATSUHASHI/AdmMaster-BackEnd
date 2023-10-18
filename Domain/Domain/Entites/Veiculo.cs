using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Domain.Entites
{
    public class Veiculo
    {
        [Key] public int tipo_veiculo_ID { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor_saida { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor_km { get; set; }
        public List<Tipo_Veiculo>? Tipo_Veiculos { get; set; }
    }
}