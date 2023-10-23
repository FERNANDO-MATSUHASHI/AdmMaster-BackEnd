using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface IAtendimentoService
    {
        void DeleteAtendimento(int id);
        List<Atendimento> GetAtendimento();
        Atendimento GetAtendimentoById(int id);
        void InsertAtendimento(AtendimentoViewModel atendimentoViewModel);
        void UpdateAtendimento(int id, AtendimentoViewModel atendimentoViewModel);
    }
}