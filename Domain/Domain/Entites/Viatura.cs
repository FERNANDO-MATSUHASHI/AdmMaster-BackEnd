namespace Domain.Entites
{
    public class Viatura
    {
        public int Id { get; set; }
        public string sigla { get; set; }
        public string obs_vtr { get; set; }
        
        public int Tipo_ViaturaId { get; set; }
        public Tipo_Viatura? Tipo_Viatura { get; set; }
        public int gerenteId { get; set; }
        public Usuario? Usuario { get; set; }

        public List<Atendimento>? Atendimentos { get; set; }

        public List<Veiculo>? Veiculos { get; set; }
    }
}
