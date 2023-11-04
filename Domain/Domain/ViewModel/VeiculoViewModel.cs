using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ViewModel
{
    public class VeiculoViewModel
    {
        public decimal valor_saida { get; set; }
        public decimal valor_km { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal adicional_noturno { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal hora_parada { get; set; }
        public int Tipo_VeiculoId { get; set; }
    }
}
