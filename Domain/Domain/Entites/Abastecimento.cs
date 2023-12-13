using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites
{
    public class Abastecimento
    {
        public int Id { get; set; }
        public DateTime data_abastecimento { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? valor_unid_abastecimento { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? qtd { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? valor_total_abastecimento { get; set; }

        public int viaturaId { get; set; }
        public Viatura? Viatura { get; set; }
        public int fornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
        public int tipo_combustivelId { get; set; }
        public Tipo_Combustivel? Tipo_Combustivel { get; set; }
        public int gerenteId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}