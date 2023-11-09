namespace Domain.ViewModel
{
    public class ComissaoReturnViewModel
    {
        public decimal Total { get; set; }
        public decimal TotalComissao { get; set; }
        public decimal Porcentagem { get; set; }
        public List<Aux> ListaAuxiliar { get; set; }
    }

    public class Aux
    {
        public DateTime data { get; set; }
        public string usuarioNome { get; set; }
        public string atendimentoNome { get; set; }
        public decimal valorAtendimento { get; set; }
        public decimal valorComissao { get; set; }
        public decimal comissaoPorcentagem { get; set; }
    }
}