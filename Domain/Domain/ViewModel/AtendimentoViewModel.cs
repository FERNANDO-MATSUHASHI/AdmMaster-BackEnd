using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ViewModel
{
    public class AtendimentoViewModel
    {
        public DateTime data { get; set; }
        public string qru { get; set; }
        public string qth { get; set; }
        public string qti { get; set; }
        public int km { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor_total { get; set; }
        public int viaturaId { get; set; }
        public int usuarioId { get; set; }
    }
}