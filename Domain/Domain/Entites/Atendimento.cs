using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites
{
    public class Atendimento
    {
        public int Id { get; set; }
        public DateTime data { get; set; }
        public string qru { get; set; }
        public bool? ris { get; set; }
        public bool? patins { get; set; }
        public bool? rodaExtra { get; set; }
        public string qth { get; set; }
        public string? qti { get; set; }
        public int? km { get; set; }
        public bool? noturno { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? qtd_hora_parada { get; set; }

        public string? obs_hora_parada { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? hospedagem { get; set; }
        public int? qtd_pedagio { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? pedagio { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal adicionais { get; set; }
        public string obs_adicionais { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal valor_total { get; set; }
        public bool? em_analise { get; set; }
        
        public int viaturaId { get; set; }
        public Viatura? Viatura { get; set; }

        public int usuarioId { get; set; }
        public int gerenteId { get; set; }
        public Usuario? Usuario { get; set; }

        public int tipoVeiculoId { get; set; }
        public Tipo_Veiculo? Tipo_Veiculo { get; set; }

        public int tipoServicoId { get; set; }
        public Tipo_Servico? Tipo_Servico { get; set; }
    }
}
