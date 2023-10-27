namespace Domain.Entites
{
    public class Cargo
    {
        public int Id { get; set; }
        public string descricao { get; set; }
        public int nivelId{ get; set; }

        public Nivel Nivel { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
