using System.ComponentModel.DataAnnotations;

namespace DDD.Domain.Entites
{
    public class Tipo_Servico
    {
        [Key] public int tipo_servico_ID { get; set; }
        public string? descricao { get; set; }
    }
}