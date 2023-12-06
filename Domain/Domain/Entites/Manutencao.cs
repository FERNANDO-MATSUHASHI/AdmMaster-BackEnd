using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites
{
    public class Manutencao
    {
        public int Id { get; set; }
        public DateTime data_manutencao { get; set; }
        public string nome_manutencao { get; set; }
        public string descricao_manutencao { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor_total_manutencao { get; set; }

        public int viaturaId { get; set; }
        public Viatura? Viatura { get; set; }
        public int gerenteId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}