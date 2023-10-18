namespace Domain.Entites
{
    public class Viatura
    {
        public int Id { get; set; }
        public string sigla { get; set; }
        public string obs_vtr { get; set; }
        public List<Tipo_Servico>? Tipo_Servicos { get; set; }
        public List<Tipo_Viatura>? Tipo_Viaturas { get; set; }
        public List<Veiculo>? Veiculos { get; set; }
    }
}
