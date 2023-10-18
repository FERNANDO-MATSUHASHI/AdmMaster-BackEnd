using Domain.Entites;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

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
        public void InsertAtendimento(Atendimento atendimento, int idViatura, int idUsuario)
        {
            try
            {
                _context.Atendimentos.Add(atendimento);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateAtendimento(Atendimento atendimento)
        {
            try
            {
                _context.Entry(atendimento).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteAtendimento(Atendimento atendimento)
        {
            try
            {
                _context.Set<Atendimento>().Remove(atendimento);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}