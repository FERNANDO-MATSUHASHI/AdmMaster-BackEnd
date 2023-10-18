namespace Domain.Entites
{
    public class Cargo
    {
        public int Id { get; set; }
        public string descricao { get; set; }
        public List<Nivel>? Niveis { get; set; }

    }
}
