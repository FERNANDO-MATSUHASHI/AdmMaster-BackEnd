using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class NivelRepository : INivelRepository
    {
        private readonly SqlContext _context;

        public NivelRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Nivel> GetNiveis()
        {
            return _context.Niveis.ToList();
        }

        public Nivel GetNivelById(int id)
        {
            return _context.Niveis.Find(id);
        }

        public void InsertNivel(Nivel nivel)
        {
            _context.Niveis.Add(nivel);
            _context.SaveChanges();
        }

        public void UpdateNivel(Nivel nivel)
        {
            _context.Update(nivel);
            _context.SaveChanges();
        }

        public void DeleteNivel(Nivel nivel)
        {
            _context.Niveis.Remove(nivel);
            _context.SaveChanges();
        }
    }
}