using Domain.Entites;

namespace Domain.Service.Services
{
    public static class FuncionalidadesService
    {
        public static decimal CalcularComissao(decimal comissaoPorcentagem, decimal valor)
        {
            var comissao = valor * (comissaoPorcentagem / 100);
            return comissao + valor;
        }

        public static decimal CalcularFaturamento(List<Atendimento> atendimentos)
        {
            decimal faturamento = 0;
            foreach (var atendimento in atendimentos)
            {
                faturamento += atendimento.valor_total;
            }

            return faturamento;
        }
    }
}