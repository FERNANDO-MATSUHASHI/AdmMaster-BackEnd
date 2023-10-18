namespace Domain.Entites
{
    public class Cargo
    {
        public int cargo_ID { get; set; }
        public string descricao { get; set; }
        public List<Nivel>? Niveis { get; set; }

    }
}
