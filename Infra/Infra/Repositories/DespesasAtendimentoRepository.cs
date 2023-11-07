using Domain.Entites;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class DespesasAtendimentoRepository : IDespesasAtendimentoRepository
    {
        private readonly SqlContext _context;

        public DespesasAtendimentoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Despesas_Atendimento> GetDespesas()
        {
            return _context.DespesasAtendimento.Include(a => a.Atendimento)
                   .Include(u => u.Atendimento.Usuario)
                   .Include(v => v.Atendimento.Viatura)
                   .ToList();
        }

        public Despesas_Atendimento GetDespesaById(int id)
        {
            return _context.DespesasAtendimento.Find(id);
        }

        public void InsertDespesa(Despesas_Atendimento despesa)
        {
            _context.DespesasAtendimento.Add(despesa);
            _context.SaveChanges();
        }
        public void UpdateDespesa(Despesas_Atendimento despesa)
        {
            _context.DespesasAtendimento.Update(despesa);
            _context.SaveChanges();
        }
        public void DeleteDespesa(Despesas_Atendimento despesa)
        {
            _context.DespesasAtendimento.Remove(despesa);
            _context.SaveChanges();
        }
    }
}