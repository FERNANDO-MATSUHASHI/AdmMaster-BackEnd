using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface IComissaoApplication
    {
        ComissaoReturnViewModel GetComissao(ComissaoViewModel comissaoViewModel);
    }
}
