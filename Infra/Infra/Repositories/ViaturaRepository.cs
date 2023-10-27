using Domain.Entites;
using Infra.Interfaces;

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
    }
}