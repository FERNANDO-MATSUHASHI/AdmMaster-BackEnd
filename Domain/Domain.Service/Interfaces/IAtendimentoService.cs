using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface IAtendimentoService
    {
        List<Atendimento> GetAtendimentos();
        Atendimento GetAtendimentoById(int id);
        void InsertAtendimento(AtendimentoViewModel atendimentoViewModel);
        void UpdateAtendimento(int id, AtendimentoViewModel atendimentoViewModel);
        void DeleteAtendimento(int id);
        List<Atendimento> GetAtendimentoByBetweenDate(DateTime dataInicial, DateTime dataFinal);
    }
}