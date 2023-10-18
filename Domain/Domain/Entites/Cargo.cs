using System.ComponentModel.DataAnnotations;

namespace DDD.Domain.Entites
{
    public class Cargo
    {
        [Key] public int cargo_ID { get; set; }
        public string? descricao { get; set; }
        public List<Nivel>? Niveis { get; set; }

    }
}
