using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;

namespace Domain.Service.Services
{
    public class TipoViaturaService : ITipoViaturaService
    {
        public readonly ITipoViaturaRepository _tipoViaturaRepository;

        public TipoViaturaService(ITipoViaturaRepository tipoViaturaRepository)
        {
            _tipoViaturaRepository = tipoViaturaRepository;
        }

        public List<Tipo_Viatura> GetTipoViaturas()
        {
            return _tipoViaturaRepository.GetTipoViaturas();
        }

        public Tipo_Viatura GetTipoViaturaById(int id)
        {
            return _tipoViaturaRepository.GetTipoViaturaById(id);
        }

        public void InsertTipoViatura(TipoViaturaViewModel tipoViaturaViewModel)
        {
            var tipoViatura = new Tipo_Viatura
            {
                marca = tipoViaturaViewModel.marca,
                modelo = tipoViaturaViewModel.modelo,
                placa = tipoViaturaViewModel.placa,
                descricao = tipoViaturaViewModel.descricao
            };

            _tipoViaturaRepository.InsertTipoViatura(tipoViatura);
        }

        public void UpdateTipoViatura(int id, TipoViaturaViewModel tipoViaturaViewModel)
        {
            var originalTipoViatura = _tipoViaturaRepository.GetTipoViaturaById(id);
            if (originalTipoViatura == null)
                throw new Exception("TipoViatura nao existe.");

            originalTipoViatura.marca = tipoViaturaViewModel.marca;
            originalTipoViatura.modelo = tipoViaturaViewModel.modelo;
            originalTipoViatura.placa = tipoViaturaViewModel.placa;
            originalTipoViatura.descricao = tipoViaturaViewModel.descricao;

            _tipoViaturaRepository.UpdateTipoViatura(originalTipoViatura);
        }

        public void DeleteTipoViatura(int id)
        {
            var originalTipoViatura = _tipoViaturaRepository.GetTipoViaturaById(id);
            if (originalTipoViatura == null)
                throw new Exception("TipoViatura nao existe.");

            _tipoViaturaRepository.DeleteTipoViatura(originalTipoViatura);
        }
    }
}
