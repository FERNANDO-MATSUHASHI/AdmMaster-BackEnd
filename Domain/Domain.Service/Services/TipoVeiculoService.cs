using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;
using Infra.Repositories;

namespace Domain.Service.Services
{
    public class TipoVeiculoService : ITipoVeiculoService
    {
        private readonly ITipoVeiculoRepository _tipoVeiculoRepository;

        public TipoVeiculoService(ITipoVeiculoRepository tipoVeiculoRepository)
        {
            _tipoVeiculoRepository = tipoVeiculoRepository;
        }

        public List<Tipo_Veiculo> GetTipoVeiculos()
        {
            return _tipoVeiculoRepository.GetTipoVeiculos();
        }

        public Tipo_Veiculo GetTipoVeiculoById(int id)
        {
            return _tipoVeiculoRepository.GetTipoVeiculoById(id);
        }

        public void InsertTipoVeiculo(TipoVeiculoViewModel tipoVeiculoViewModel)
        {
            var tipoVeiculo = new Tipo_Veiculo
            {
                modelo = tipoVeiculoViewModel.modelo,
                descricao = tipoVeiculoViewModel.descricao,
                gerenteId = tipoVeiculoViewModel.gerenteId,
            };

            _tipoVeiculoRepository.InsertTipoVeiculo(tipoVeiculo);
        }

        public void UpdateTipoVeiculo(int id, TipoVeiculoViewModel tipoVeiculoViewModel)
        {
            var originalTipoVeiculo = _tipoVeiculoRepository.GetTipoVeiculoById(id);
            if (originalTipoVeiculo == null)
                throw new Exception("TipoVeiculo nao existe.");

            originalTipoVeiculo.modelo = tipoVeiculoViewModel.modelo;
            originalTipoVeiculo.descricao = tipoVeiculoViewModel.descricao;
            originalTipoVeiculo.gerenteId = tipoVeiculoViewModel.gerenteId;

            _tipoVeiculoRepository.UpdateTipoVeiculo(originalTipoVeiculo);
        }

        public void DeleteTipoVeiculo(int id)
        {
            var originalTipoVeiculo = _tipoVeiculoRepository.GetTipoVeiculoById(id);
            if (originalTipoVeiculo == null)
                throw new Exception("TipoVeiculo nao existe.");

            _tipoVeiculoRepository.DeleteTipoVeiculo(originalTipoVeiculo);
        }
        public List<Tipo_Veiculo> GetTipoVeiculosByGerenteId(int gerenteId)
        {
            var tipoVeivulosViewModel = _tipoVeiculoRepository.GetTipoVeiculosByGerenteId(gerenteId);

            return tipoVeivulosViewModel;
        }
    }
}