using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;
using Infra.Repositories;

namespace Domain.Service.Services
{
    public class AbastecimentoService : IAbastecimentoService
    {
        public readonly IAbastecimentoRepository _abastecimentoRepository;

        public AbastecimentoService(IAbastecimentoRepository abastecimentoRepository)
        {
            _abastecimentoRepository = abastecimentoRepository;
        }

        public List<Abastecimento> GetAbastecimentos()
        {
            return _abastecimentoRepository.GetAbastecimentos();
        }

        public Abastecimento GetAbastecimentoById(int id)
        {
            return _abastecimentoRepository.GetAbastecimentoById(id);
        }

        public void InsertAbastecimento(AbastecimentoViewModel abastecimentoViewModel)
        {
            var abastecimento = new Abastecimento
            {
                data_abastecimento = abastecimentoViewModel.data_abastecimento,
                valor_unid_abastecimento = abastecimentoViewModel.valor_unid_abastecimento,
                valor_total_abastecimento = abastecimentoViewModel.valor_total_abastecimento,
                viaturaId = abastecimentoViewModel.viaturaId,
                fornecedorId = abastecimentoViewModel.fornecedorId,
                tipo_combustivelId = abastecimentoViewModel.tipo_combustivelId,
                gerenteId = abastecimentoViewModel.gerenteId
            };

            _abastecimentoRepository.InsertAbastecimento(abastecimento);
        }

        public void UpdateAbastecimento(int id, AbastecimentoViewModel abastecimentoViewModel)
        {
            var originalAbastecimento = _abastecimentoRepository.GetAbastecimentoById(id);
            if (originalAbastecimento == null)
                throw new Exception("Abastecimento nao existe.");

            originalAbastecimento.data_abastecimento = abastecimentoViewModel.data_abastecimento;
            originalAbastecimento.valor_unid_abastecimento = abastecimentoViewModel.valor_unid_abastecimento;
            originalAbastecimento.valor_total_abastecimento = abastecimentoViewModel.valor_total_abastecimento;
            originalAbastecimento.viaturaId = abastecimentoViewModel.viaturaId;
            originalAbastecimento.fornecedorId = abastecimentoViewModel.fornecedorId;
            originalAbastecimento.tipo_combustivelId = abastecimentoViewModel.tipo_combustivelId;
            originalAbastecimento.gerenteId = abastecimentoViewModel.gerenteId;

            _abastecimentoRepository.UpdateAbastecimento(originalAbastecimento);
        }

        public void DeleteAbastecimento(int id)
        {
            var originalAbastecimento = _abastecimentoRepository.GetAbastecimentoById(id);
            if (originalAbastecimento == null)
                throw new Exception("Abastecimento nao existe.");

            _abastecimentoRepository.DeleteAbastecimento(originalAbastecimento);
        }
        public List<Abastecimento> GetAbastecimentoGerenteById(int gerenteId)
        {
            return _abastecimentoRepository.GetAbastecimentoGerenteById(gerenteId);
        }
    }
}
