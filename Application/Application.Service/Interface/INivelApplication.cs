using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface INivelApplication
    {
        void DeleteNivel(int id);
        List<Nivel> GetNiveis();
        Nivel GetNivelById(int id);
        void InsertNivel(NivelViewModel nivelViewModel);
        void UpdateNivel(int id, NivelViewModel nivelViewModel);
    }
}