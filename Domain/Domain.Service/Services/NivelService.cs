using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;

namespace Domain.Service.Services
{
    public class NivelService : INivelService
    {
        private readonly INivelRepository _nivelRepository;

        public NivelService(INivelRepository nivelRepository)
        {
            _nivelRepository = nivelRepository;
        }

        public List<Nivel> GetNiveis()
        {
            return _nivelRepository.GetNiveis();
        }

        public Nivel GetNivelById(int id)
        {
            return _nivelRepository.GetNivelById(id);
        }

        public void InsertNivel(NivelViewModel nivelViewModel)
        {
            var nivel = new Nivel
            {
                nivel = nivelViewModel.nivel,
                descricao = nivelViewModel.descricao
            };

            _nivelRepository.InsertNivel(nivel);
        }

        public void UpdateNivel(int id, NivelViewModel nivelViewModel)
        {
            var originalNivel = _nivelRepository.GetNivelById(id);
            if (originalNivel == null)
                throw new Exception("Nivel nao existe.");

            originalNivel.nivel = nivelViewModel.nivel;
            originalNivel.descricao = nivelViewModel.descricao;

            _nivelRepository.UpdateNivel(originalNivel);
        }

        public void DeleteNivel(int id)
        {
            var originalNivel = _nivelRepository.GetNivelById(id);
            if (originalNivel == null)
                throw new Exception("Nivel nao existe.");

            _nivelRepository.DeleteNivel(originalNivel);
        }
    }
}