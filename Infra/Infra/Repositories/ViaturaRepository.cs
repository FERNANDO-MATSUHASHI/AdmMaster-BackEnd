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

        public List<Viatura> GetViaturas()
        {
            return _context.Viaturas.ToList();
        }

        public Viatura GetViaturaById(int id)
        {
            return _context.Viaturas.Find(id);
        }

        public void InsertViatura(Viatura viatura)
        {
            _context.Viaturas.Add(viatura);
            _context.SaveChanges();
        }
        public void UpdateViatura(Viatura viatura)
        {
            _context.Viaturas.Update(viatura);
            _context.SaveChanges();
        }
        public void DeleteViatura(Viatura viatura)
        {
            _context.Viaturas.Remove(viatura);
            _context.SaveChanges();
        }
        public List<Viatura> GetViaturasByGerenteId(int gerenteId)
        {
            var query = (from i in _context.Viaturas.AsNoTracking()
                         where i.gerenteId == gerenteId
                         select new Viatura
                         {
                             Id = i.Id,
                             sigla = i.sigla,
                             obs_vtr = i.obs_vtr,
                             Tipo_ViaturaId = i.Tipo_ViaturaId,
                             gerenteId = i.gerenteId
                         });
            return query.ToList();
        }
    }
}