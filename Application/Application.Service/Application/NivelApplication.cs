using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class NivelApplication : INivelApplication
    {
        private readonly INivelService _nivelService;

        public NivelApplication(INivelService nivelService)
        {
            _nivelService = nivelService;
        }

        public List<Nivel> GetNiveis()
        {
            return _nivelService.GetNiveis();
        }

        public Nivel GetNivelById(int id)
        {
            return _nivelService.GetNivelById(id);
        }

        public void InsertNivel(NivelViewModel nivelViewModel)
        {
            _nivelService.InsertNivel(nivelViewModel);
        }

        public void UpdateNivel(int id, NivelViewModel nivelViewModel)
        {
            _nivelService.UpdateNivel(id, nivelViewModel);
        }

        public void DeleteNivel(int id)
        {
            _nivelService.DeleteNivel(id);
        }
    }
}