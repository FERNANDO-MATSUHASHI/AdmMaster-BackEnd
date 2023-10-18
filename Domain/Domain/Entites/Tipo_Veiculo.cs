using System.ComponentModel.DataAnnotations;

namespace DDD.Domain.Entites
{
    public class Tipo_Veiculo
    {
        [Key] public int tipo_veiculo_ID { get; set; }
        public string? marca { get; set; }
        public string? modelo { get; set; }
        public string? plcaca { get; set; }
        public string? descricao { get; set; }
    }
}