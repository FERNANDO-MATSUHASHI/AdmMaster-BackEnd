using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;
using Infra.Repositories;

namespace Domain.Service.Services
{
    public class TipoCombustivelService : ITipoCombustivelService
    {
        public readonly ITipoCombustivelRepository _tipoCombustivelRepository;

        public TipoCombustivelService(ITipoCombustivelRepository tipoCombustivelRepository)
        {
            _tipoCombustivelRepository = tipoCombustivelRepository;
        }

        public List<Tipo_Combustivel> GetTipoCombustiveis()
        {
            return _tipoCombustivelRepository.GetTipoCombustiveis();
        }

        public Tipo_Combustivel GetTipoCombustivelById(int id)
        {
            return _tipoCombustivelRepository.GetTipoCombustivelById(id);
        }

        public void InsertTipoCombustivel(TipoCombustivelViewModel tipoCombustivelViewModel)
        {
            var tipoCombustivel = new Tipo_Combustivel
            {
                nome_combustivel = tipoCombustivelViewModel.nome_combustivel,
                gerenteId = tipoCombustivelViewModel.gerenteId
            };

            _tipoCombustivelRepository.InsertTipoCombustivel(tipoCombustivel);
        }

        public void UpdateTipoCombustivel(int id, TipoCombustivelViewModel tipoCombustivelViewModel)
        {
            var originalTipoCombustivel = _tipoCombustivelRepository.GetTipoCombustivelById(id);
            if (originalTipoCombustivel == null)
                throw new Exception("TipoCombustivel nao existe.");

            originalTipoCombustivel.nome_combustivel = tipoCombustivelViewModel.nome_combustivel;
            originalTipoCombustivel.gerenteId = tipoCombustivelViewModel.gerenteId;

            _tipoCombustivelRepository.UpdateTipoCombustivel(originalTipoCombustivel);
        }

        public void DeleteTipoCombustivel(int id)
        {
            var originalTipoCombustivel = _tipoCombustivelRepository.GetTipoCombustivelById(id);
            if (originalTipoCombustivel == null)
                throw new Exception("TipoCombustivel nao existe.");

            _tipoCombustivelRepository.DeleteTipoCombustivel(originalTipoCombustivel);
        }
        public List<Tipo_Combustivel> GetTipo_CombustivelGerenteById(int gerenteId)
        {
            return _tipoCombustivelRepository.GetTipo_CombustivelGerenteById(gerenteId);
        }

    }
}
