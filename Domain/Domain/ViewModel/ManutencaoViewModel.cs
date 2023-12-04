using Domain.Entites;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ViewModel
{
    public class ManutencaoViewModel
    {
        public string nome_manutencao { get; set; }
        public string descricao_manutencao { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor_total_manutencao { get; set; }

        public int viaturaId { get; set; }
        public int gerenteId { get; set; }
    }
}