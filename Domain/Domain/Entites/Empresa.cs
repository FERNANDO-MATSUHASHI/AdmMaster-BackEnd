namespace Domain.Entites
{
    public class Empresa
    {
        public int Id { get; set; }
        public string nome_empresa { get; set; }
        public int gerenteId { get; set; }
        public Usuario? Usuario { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
