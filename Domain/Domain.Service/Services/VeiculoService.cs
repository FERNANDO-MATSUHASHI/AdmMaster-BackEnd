using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;
using Infra.Repositories;

namespace Domain.Service.Services
{
    public class VeiculoService : IVeiculoService
    {
        public readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public List<Veiculo> GetVeiculos()
        {
            return _veiculoRepository.GetVeiculos();
        }

        public Veiculo GetVeiculoById(int id)
        {
            return _veiculoRepository.GetVeiculoById(id);
        }

        public void InsertVeiculo(VeiculoViewModel veiculoViewModel)
        {
            var veiculo = new Veiculo
            {
                valor_saida = veiculoViewModel.valor_saida,
                valor_km = veiculoViewModel.valor_km,
                adicional_noturno = veiculoViewModel.adicional_noturno,
                ris = veiculoViewModel.ris,
                patins = veiculoViewModel.patins,
                rodaExtra = veiculoViewModel.rodaExtra,
                hora_parada = veiculoViewModel.hora_parada,
                descricao = veiculoViewModel.descricao,
                Tipo_ServicoId = veiculoViewModel.Tipo_ServicoId,
                Tipo_VeiculoId = veiculoViewModel.Tipo_VeiculoId,
                viaturaId = veiculoViewModel.viaturaId,
                gerenteId = veiculoViewModel.gerenteId
            };

            _veiculoRepository.InsertVeiculo(veiculo);
        }

        public void UpdateVeiculo(int id, VeiculoViewModel veiculoViewModel)
        {
            var originalVeiculo = _veiculoRepository.GetVeiculoById(id);
            if (originalVeiculo == null)
                throw new Exception("Veiculo nao existe.");

            originalVeiculo.valor_saida = veiculoViewModel.valor_saida;
            originalVeiculo.valor_km = veiculoViewModel.valor_km;
            originalVeiculo.adicional_noturno = veiculoViewModel.adicional_noturno;
            originalVeiculo.ris = veiculoViewModel.ris;
            originalVeiculo.patins = veiculoViewModel.patins;
            originalVeiculo.rodaExtra = veiculoViewModel.rodaExtra;
            originalVeiculo.hora_parada = veiculoViewModel.hora_parada;
            originalVeiculo.descricao = veiculoViewModel.descricao;
            originalVeiculo.Tipo_ServicoId = veiculoViewModel.Tipo_ServicoId;
            originalVeiculo.Tipo_VeiculoId = veiculoViewModel.Tipo_VeiculoId;
            originalVeiculo.viaturaId = veiculoViewModel.viaturaId;
            originalVeiculo.gerenteId = veiculoViewModel.gerenteId;

            _veiculoRepository.UpdateVeiculo(originalVeiculo);
        }

        public void DeleteVeiculo(int id)
        {
            var originalVeiculo = _veiculoRepository.GetVeiculoById(id);
            if (originalVeiculo == null)
                throw new Exception("Veiculo nao existe.");

            _veiculoRepository.DeleteVeiculo(originalVeiculo);
        }
        public List<Veiculo> GetVeiculosByGerenteId(int gerenteId)
        {
            var veiculoViewModel = _veiculoRepository.GetVeiculosByGerenteId(gerenteId);

            return veiculoViewModel;
        }
    }
}
