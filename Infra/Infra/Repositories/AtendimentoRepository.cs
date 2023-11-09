using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class AtendimentoRepository : IAtendimentoRepository
    {
        private readonly SqlContext _context;

        public AtendimentoRepository(SqlContext context)
        {
            _context = context;
        }
        public List<Atendimento> GetAtendimentos()
        {
            return _context.Atendimentos.ToList();
        }
        public Atendimento GetAtendimentoById(int id)
        {
            return _context.Atendimentos.Find(id);
        }
        public void InsertAtendimento(Atendimento atendimento)
        {
            _context.Atendimentos.Add(atendimento);
            _context.SaveChanges();
        }
        public void UpdateAtendimento(Atendimento atendimento)
        {
            _context.Atendimentos.Update(atendimento);
            _context.SaveChanges();
        }
        public void DeleteAtendimento(Atendimento atendimento)
        {
            _context.Atendimentos.Remove(atendimento);
            _context.SaveChanges();
        }
        public List<Atendimento> GetAtendimentoByBetweenDate(DateTime dataInicial, DateTime dataFinal, int usuarioId)
        {
            return _context.Atendimentos.Where(x => x.data >= dataInicial && x.data <= dataFinal && x.usuarioId == usuarioId).ToList();
        }
    }
}