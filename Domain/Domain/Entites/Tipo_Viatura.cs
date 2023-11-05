namespace Domain.Entites
{
    public class Tipo_Viatura
    {
        public int Id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public string descricao { get; set; }

        public List<Viatura> Viaturas { get; set; }
    }
}