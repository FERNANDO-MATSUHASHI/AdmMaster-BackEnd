namespace Domain.Entites
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string cnpj { get; set; }
        public string razao_social { get; set; }
        public string nome_fantasia { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public int cep { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }

        public int gerenteId { get; set; }
        public Usuario? Usuario { get; set; }

        public List<Abastecimento>? Abastecimentos { get; set; }
    }
}