using Domain.Entites;
using Infra.Interfaces;

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
            _context.Tipo_Viaturas.Add(tipoViatura);
            _context.SaveChanges();
        }

        public void UpdateTipoViatura(Tipo_Viatura tipoViatura)
        {
            _context.Tipo_Viaturas.Update(tipoViatura);
            _context.SaveChanges();
        }
        public void DeleteTipoViatura(Tipo_Viatura tipoViatura)
        {
            _context.Tipo_Viaturas.Remove(tipoViatura);
            _context.SaveChanges();
        }
    }
}