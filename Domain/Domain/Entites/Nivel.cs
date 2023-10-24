namespace Domain.Entites
{
    public class Nivel
    {
        public int Id { get; set; }
        public int nivel { get; set; }
        public string descricao { get; set; }

        public List<Cargo>? Cargos { get; set; }
    }
}
