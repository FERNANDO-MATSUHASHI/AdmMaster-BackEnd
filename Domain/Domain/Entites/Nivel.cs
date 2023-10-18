using System.ComponentModel.DataAnnotations;

namespace DDD.Domain.Entites
{
    public class Nivel
    {
        [Key] public int nivel_ID { get; set; }
        public int nivel { get; set; }
        public string? descricao { get; set; }
    }
}
