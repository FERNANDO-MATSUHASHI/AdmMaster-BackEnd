using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface IComissaoService
    {
        ComissaoReturnViewModel GetComissao(Usuario usuario, List<Atendimento> atendimento);
    }
}
