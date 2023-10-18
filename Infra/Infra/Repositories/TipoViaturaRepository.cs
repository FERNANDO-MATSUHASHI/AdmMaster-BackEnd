using Domain.Entites;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class TipoViaturaRepository : ITipoViaturaRepository
    {
        private readonly SqlContext _context;

        public TipoViaturaRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Tipo_Viatura> GetTipoViatura()
        {
            return _context.Tipo_Viaturas.ToList();
        }

        public Tipo_Viatura GetTipoViaturaById(int id)
        {
            return _context.Tipo_Viaturas.Find(id);
        }

        public void InsertTipoViatura(Tipo_Viatura tipoViatura)
        {
            try
            {
                _context.Tipo_Viaturas.Add(tipoViatura);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateTipoViatura(Tipo_Viatura tipoViatura)
        {
            try
            {
                _context.Entry(tipoViatura).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteTipoViatura(Tipo_Viatura tipoViatura)
        {
            try
            {
                _context.Set<Tipo_Viatura>().Remove(tipoViatura);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}