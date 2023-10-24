using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface INivelService
    {
        void DeleteNivel(int id);
        List<Nivel> GetNiveis();
        Nivel GetNivelById(int id);
        void InsertNivel(NivelViewModel nivelViewModel);
        void UpdateNivel(int id, NivelViewModel nivelViewModel);
    }
}