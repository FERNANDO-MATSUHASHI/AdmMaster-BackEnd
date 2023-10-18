using System.ComponentModel.DataAnnotations;

namespace DDD.Domain.Entites
{
    public class Tipo_Viatura
    {
        [Key] public int tipo_viatura_ID { get; set; }
        public string? descricao { get; set; }

    }
}