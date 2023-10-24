using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface IAtendimentoApplication
    {
        void DeleteAtendimento(int id);
        List<Atendimento> GetAtendimentos();
        Atendimento GetAtendimentoById(int id);
        void InsertAtendimento(AtendimentoViewModel atendimentoViewModel);
        void UpdateAtendimento(int id, AtendimentoViewModel atendimentoViewModel);
    }
}