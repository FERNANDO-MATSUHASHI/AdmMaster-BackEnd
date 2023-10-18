using AdmMaster.Infra.MemoryDb.Interfaces;
using DDD.Domain.Entites;
using Domain.Entites;
using Infra;
using Microsoft.EntityFrameworkCore;

namespace AdmMaster.Infra.MemoryDb.Repositories
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
                //log exception
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
                //log exception
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
                //log exception
                throw ex;
            }
        }
    }
}
