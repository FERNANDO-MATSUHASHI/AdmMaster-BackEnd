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

        public DespesasAtendimentoService(IDespesasAtendimentoRepository despesasRepository, IAtendimentoRepository atendimentoRepository)
        {
            _despesasRepository = despesasRepository;
            _atendimentoRepository = atendimentoRepository;
        }

        public List<Despesas_Atendimento> GetDespesas()
        {
            return _despesasRepository.GetDespesas();
        }

        public List<Despesas_Atendimento> GetDespesasByFilter(string? qru, DateTime? dataInicial, DateTime? dataFinal)
        {
            return _despesasRepository.GetDespesasByFilter(qru, dataInicial, dataFinal);
        }

        public Viatura GetInfoViatura(int id)
        {
            return _despesasRepository.GetInfoViatura(id);
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
                tipo = DespesaViewModel.tipo,
                descricao = DespesaViewModel.descricao,
                valor = DespesaViewModel.valor
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
            despesa.tipo = despesaViewModel.tipo;
            despesa.descricao = despesaViewModel.descricao;
            despesa.valor = despesaViewModel.valor;

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