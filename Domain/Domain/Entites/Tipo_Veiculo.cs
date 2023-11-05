namespace Domain.Entites
{
    public class Tipo_Veiculo
    {
        public int Id { get; set; }
        public string modelo { get; set; }
        public string descricao { get; set; }

        public List<Veiculo> Veiculos { get; set; }
    }
}