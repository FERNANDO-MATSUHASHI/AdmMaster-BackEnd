using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;
using Infra.Repositories;

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
                ano = tipoViaturaViewModel.ano,
                ano_modelo = tipoViaturaViewModel.ano_modelo,
                descricao = tipoViaturaViewModel.descricao,
                gerenteId = tipoViaturaViewModel.gerenteId
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
            originalTipoViatura.ano = tipoViaturaViewModel.ano;
            originalTipoViatura.ano_modelo = tipoViaturaViewModel.ano_modelo;
            originalTipoViatura.descricao = tipoViaturaViewModel.descricao;
            originalTipoViatura.gerenteId = tipoViaturaViewModel.gerenteId;

            _tipoViaturaRepository.UpdateTipoViatura(originalTipoViatura);
        }

        public void DeleteTipoViatura(int id)
        {
            var originalTipoViatura = _tipoViaturaRepository.GetTipoViaturaById(id);
            if (originalTipoViatura == null)
                throw new Exception("TipoViatura nao existe.");

            _tipoViaturaRepository.DeleteTipoViatura(originalTipoViatura);
        }
        public List<Tipo_Viatura> GetTipoViaturasByGerenteId(int gerenteId)
        {
            var tipoViaturasViewModel = _tipoViaturaRepository.GetTipoViaturasByGerenteId(gerenteId);

            return tipoViaturasViewModel;
        }
    }
}
