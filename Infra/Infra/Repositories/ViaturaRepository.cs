using Domain.Entites;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class ViaturaRepository : IViaturaRepository
    {
        private readonly SqlContext _context;

        public ViaturaRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Viatura> GetViatura()
        {
            return _context.Viaturas.ToList();
        }

        public Viatura GetViaturaById(int id)
        {
            return _context.Viaturas.Find(id);
        }

        public void InsertViatura(Viatura viatura, int idTipoServico, int idTipoViatura, int idTipoVeiculo)
        {
            try
            {
                _context.Viaturas.Add(viatura);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateViatura(Viatura viatura)
        {
            try
            {
                _context.Entry(viatura).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteViatura(Viatura viatura)
        {
            try
            {
                _context.Set<Viatura>().Remove(viatura);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}