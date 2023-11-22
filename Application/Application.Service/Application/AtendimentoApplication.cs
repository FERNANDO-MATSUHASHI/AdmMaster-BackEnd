using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class AtendimentoApplication : IAtendimentoApplication
    {
        private readonly IAtendimentoService _atendimentoService;

        public AtendimentoApplication(IAtendimentoService atendimentoService)
        {
            _atendimentoService = atendimentoService;
        }

        public List<Atendimento> GetAtendimentos()
        {
            return _atendimentoService.GetAtendimentos();
        }

        public Atendimento GetAtendimentoById(int id)
        {
            return _atendimentoService.GetAtendimentoById(id);
        }

        public void InsertAtendimento(AtendimentoViewModel atendimentoViewModel)
        {
            _atendimentoService.InsertAtendimento(atendimentoViewModel);
        }

        public void UpdateAtendimento(int id, AtendimentoViewModel atendimentoViewModel)
        {
            _atendimentoService.UpdateAtendimento(id, atendimentoViewModel);
        }

        public void DeleteAtendimento(int id)
        {
            _atendimentoService.DeleteAtendimento(id);
        }

        public List<Atendimento> GetAtendimentoGerenteById(int gerenteId)
        {
            return _atendimentoService.GetAtendimentoGerenteById(gerenteId);
        }
    }
}