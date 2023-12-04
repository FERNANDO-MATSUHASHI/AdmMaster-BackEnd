using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.Service.Services;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class AbastecimentoApplication : IAbastecimentoApplication
    {
        private readonly IAbastecimentoService _abastecimentoService;

        public AbastecimentoApplication(IAbastecimentoService abastecimentoService)
        {
            _abastecimentoService = abastecimentoService;
        }

        public List<Abastecimento> GetAbastecimentos()
        {
            return _abastecimentoService.GetAbastecimentos();
        }

        public Abastecimento GetAbastecimentoById(int id)
        {
            return _abastecimentoService.GetAbastecimentoById(id);
        }

        public void InsertAbastecimento(AbastecimentoViewModel abastecimentoViewModel)
        {
            _abastecimentoService.InsertAbastecimento(abastecimentoViewModel);
        }

        public void UpdateAbastecimento(int id, AbastecimentoViewModel abastecimentoViewModel)
        {
            _abastecimentoService.UpdateAbastecimento(id, abastecimentoViewModel);
        }

        public void DeleteAbastecimento(int id)
        {
            _abastecimentoService.DeleteAbastecimento(id);
        }
        public List<Abastecimento> GetAbastecimentoGerenteById(int gerenteId)
        {
            return _abastecimentoService.GetAbastecimentoGerenteById(gerenteId);
        }
    }
}
