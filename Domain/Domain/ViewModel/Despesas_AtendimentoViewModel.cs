using Domain.Entites;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ViewModel
{
    public class Despesas_AtendimentoViewModel
    {
        public int AtendimentoId { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor { get; set; }
    }
}