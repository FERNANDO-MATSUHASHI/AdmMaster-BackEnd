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
            decimal total = 0;

            foreach (var item in atendimento) 
            {
                var comissao = FuncionalidadesService.CalcularComissao(usuario.comissao, item.valor_total);
                var teste = new Aux
                {
                    data = item.data,
                    usuarioNome = usuario.nome,
                    atendimentoNome = "teste" ,
                    valorAtendimento = item.valor_total,
                    valorComissao = comissao
                };
                retorno.ListaAuxiliar.Add(teste);
                total += item.valor_total;
            }
            retorno.Total = total;

            return retorno;
        }
    }
}
