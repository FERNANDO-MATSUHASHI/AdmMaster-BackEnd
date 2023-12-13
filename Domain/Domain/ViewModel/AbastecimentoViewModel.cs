using Domain.Entites;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ViewModel
{
    public class AbastecimentoViewModel
    {
        public DateTime data_abastecimento { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? valor_unid_abastecimento { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? qtd { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? valor_total_abastecimento { get; set; }

        public int viaturaId { get; set; }
        public int fornecedorId { get; set; }
        public int tipo_combustivelId { get; set; }
        public int gerenteId { get; set; }
    }
}