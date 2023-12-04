using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.Service.Services;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class ManutencaoApplication : IManutencaoApplication
    {
        private readonly IManutencaoService _manutencaoService;

        public ManutencaoApplication(IManutencaoService manutencaoService)
        {
            _manutencaoService = manutencaoService;
        }

        public List<Manutencao> GetManutencoes()
        {
            return _manutencaoService.GetManutencoes();
        }

        public Manutencao GetManutencaoById(int id)
        {
            return _manutencaoService.GetManutencaoById(id);
        }

        public void InsertManutencao(ManutencaoViewModel manutencaoViewModel)
        {
            _manutencaoService.InsertManutencao(manutencaoViewModel);
        }

        public void UpdateManutencao(int id, ManutencaoViewModel manutencaoViewModel)
        {
            _manutencaoService.UpdateManutencao(id, manutencaoViewModel);
        }

        public void DeleteManutencao(int id)
        {
            _manutencaoService.DeleteManutencao(id);
        }
        public List<Manutencao> GetManutencaoGerenteById(int gerenteId)
        {
            return _manutencaoService.GetManutencaoGerenteById(gerenteId);
        }
    }
}
