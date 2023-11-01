using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;

namespace Domain.Service.Services
{
    public class DespesasAtendimentoService : IDespesasAtendimentoService
    {
        private readonly IDespesasAtendimentoRepository _despesasRepository;
        private readonly IAtendimentoRepository _atendimentoRepository;

        public DespesasAtendimentoService(IDespesasAtendimentoRepository despesasRepository)
        {
            _despesasRepository = despesasRepository;
        }

        public List<Despesas_Atendimento> GetDespesas()
        {
            return _despesasRepository.GetDespesas();
        }

        public Despesas_Atendimento GetDespesaById(int id)
        {
            return _despesasRepository.GetDespesaById(id);
        }

        public void InsertDespesa(Despesas_AtendimentoViewModel DespesaViewModel)
        {
            var despesa = new Despesas_Atendimento
            {
                AtendimentoId = DespesaViewModel.AtendimentoId,
                valor_comissao = DespesaViewModel.valor_comissao
            };

            _despesasRepository.InsertDespesa(despesa);
        }

        public void UpdateDespesa(int id, Despesas_AtendimentoViewModel despesaViewModel)
        {
            var atendimento = _atendimentoRepository.GetAtendimentoById(despesaViewModel.AtendimentoId);
            var despesa = _despesasRepository.GetDespesaById(id);
            if (despesa == null)
                throw new Exception("Despesa de Atendimento não existe.");
            if (atendimento == null)
                throw new Exception("Atendimento não existe.");

            despesa.AtendimentoId = despesaViewModel.AtendimentoId;
            despesa.valor_comissao = despesaViewModel.valor_comissao;

            _despesasRepository.UpdateDespesa(despesa);
        }

        public void DeleteDespesa(int id)
        {
            var despesa = _despesasRepository.GetDespesaById(id);
            if (despesa == null)
                throw new Exception("Despesa de Atendimento não existe.");

            _despesasRepository.DeleteDespesa(despesa);
        }
    }
}