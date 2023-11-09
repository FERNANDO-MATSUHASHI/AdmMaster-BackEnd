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
            }
            retorno.Total = total;
            retorno.TotalComissao = totalComissao;
            retorno.Porcentagem = usuario.comissao;

            return retorno;
        }
    }
}
