using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;
using Infra.Repositories;

namespace Domain.Service.Services
{
    public class ViaturaService : IViaturaService
    {
        public readonly IViaturaRepository _viaturaRepository;

        public ViaturaService(IViaturaRepository viaturaRepository)
        {
            _viaturaRepository = viaturaRepository;
        }

        public List<Viatura> GetViaturas()
        {
            return _viaturaRepository.GetViaturas();
        }

        public Viatura GetViaturaById(int id)
        {
            return _viaturaRepository.GetViaturaById(id);
        }

        public void InsertViatura(ViaturaViewModel viaturaViewModel)
        {
            var viatura = new Viatura
            {
                sigla = viaturaViewModel.sigla,
                obs_vtr = viaturaViewModel.obs_vtr,
                Tipo_ViaturaId = viaturaViewModel.Tipo_ViaturaId,
                gerenteId = viaturaViewModel.gerenteId,
            };

            _viaturaRepository.InsertViatura(viatura);
        }

        public void UpdateViatura(int id, ViaturaViewModel viaturaViewModel)
        {
            var originalViatura = _viaturaRepository.GetViaturaById(id);
            if (originalViatura == null)
                throw new Exception("Viatura nao existe.");

            originalViatura.sigla = viaturaViewModel.sigla;
            originalViatura.obs_vtr = viaturaViewModel.obs_vtr;
            originalViatura.Tipo_ViaturaId = viaturaViewModel.Tipo_ViaturaId;
            originalViatura.gerenteId = viaturaViewModel.gerenteId;

            _viaturaRepository.UpdateViatura(originalViatura);
        }

        public void DeleteViatura(int id)
        {
            var originalViatura = _viaturaRepository.GetViaturaById(id);
            if (originalViatura == null)
                throw new Exception("Viatura nao existe.");

            _viaturaRepository.DeleteViatura(originalViatura);
        }
        public List<Viatura> GetViaturasByGerenteId(int gerenteId)
        {
            var viaturasViewModel = _viaturaRepository.GetViaturasByGerenteId(gerenteId);

            return viaturasViewModel;
        }
    }
}
