using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;

namespace Domain.Service.Services
{
    public class ComissaoService : IComissaoService
    {

        public ComissaoReturnViewModel GetComissao(Usuario usuario, List<Atendimento> atendimento)
        {
            var retorno = new ComissaoReturnViewModel();
            retorno.ListaAuxiliar = new List<Aux>();
            decimal total = 0;
            decimal totalComissao = 0;
            int qtdAtendimentoTotal = 0;

            foreach (var item in atendimento) 
            {
                var comissao = FuncionalidadesService.CalcularComissao(usuario.comissao, item.valor_total);
                var teste = new Aux
                {
                    data = item.data,
                    usuarioNome = usuario.nome,
                    atendimentoNome = item.qru,
                    valorAtendimento = item.valor_total,
                    valorComissao = comissao,
                    comissaoPorcentagem = usuario.comissao
                };
                retorno.ListaAuxiliar.Add(teste);
                total += item.valor_total;
                totalComissao += comissao;
                qtdAtendimentoTotal += 1;
            }
            retorno.Total = total;
            retorno.TotalComissao = Math.Round(totalComissao, 2);
            retorno.Porcentagem = usuario.comissao;
            retorno.qtdAtendimento = qtdAtendimentoTotal;

            return retorno;
        }
    }
}
