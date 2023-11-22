using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class DespesasAtendimentoApplication : IDespesasAtendimentoApplication
    {
        private readonly IDespesasAtendimentoService _despesaService;

        public DespesasAtendimentoApplication(IDespesasAtendimentoService despesaService)
        {
            _despesaService = despesaService;
        }

        public List<Despesas_Atendimento> GetDespesas()
        {
            return _despesaService.GetDespesas();
        }

        public List<Despesas_Atendimento> GetDespesasByFilter(string? qru, DateTime? dataInicial, DateTime? dataFinal)
        {
            return _despesaService.GetDespesasByFilter(qru, dataInicial, dataFinal);
        }

        public Viatura GetInfoViatura(int id)
        {
            return _despesaService.GetInfoViatura(id);
        }

        public Despesas_Atendimento GetDespesaById(int id)
        {
            return _despesaService.GetDespesaById(id);
        }

        public void InsertDespesa(Despesas_AtendimentoViewModel despesaViewModel)
        {
            _despesaService.InsertDespesa(despesaViewModel);
        }

        public void UpdateDespesa(int id, Despesas_AtendimentoViewModel despesaViewModel)
        {
            _despesaService.UpdateDespesa(id, despesaViewModel);
        }

        public void DeleteDespesa(int id)
        {
            _despesaService.DeleteDespesa(id);
        }
        public List<Despesas_Atendimento> GetDespesaGerenteById(int gerenteId)
        {
            return _despesaService.GetDespesaGerenteById(gerenteId);
        }
    }
}