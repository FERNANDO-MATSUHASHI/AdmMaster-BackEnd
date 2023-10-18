using Domain.Entites;

namespace Infra.Interfaces
{
    public interface INivelRepository
    {
        public List<Nivel> GetNivel();
        public Nivel GetNivelById(int id);
        public void InsertNivel(Nivel nivel);
        public void UpdateNivel(Nivel nivel);
        public void DeleteNivel(Nivel nivel);
    }
}