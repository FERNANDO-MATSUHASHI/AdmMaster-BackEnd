using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites
{
    public class Atendimento
    {
        public int Id { get; set; }
        public DateTime data { get; set; }
        public string qru { get; set; }
        public string qth { get; set; }
        public string? qti { get; set; }
        public int km { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal noturno { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor_total { get; set; }
        
        public int viaturaId { get; set; }
        public Viatura? Viatura { get; set; }

        public int usuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        //public List<Usuario>? Usuarios { get; set; }
    }
}
