namespace DDD.Domain.Entites
{
    public class Usuario
    {
        public int usuario_ID { get; set; }
        public string nome { get; set; }
        public int cpf { get; set; }
        public string email { get; set; }
        public DateTime data_nascimento { get; set; }
        public DateTime criado_em { get; set; }
        public int cep { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string user_name { get; set; }
        public string senha { get; set; }
        public bool ativo { get; set; }
        public List<Cargo>? Cargos { get; set; }
    }
}
