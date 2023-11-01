using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ViewModel
{
    public class Despesas_AtendimentoViewModel
    {
        public int AtendimentoId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal valor_comissao { get; set; }
    }
}