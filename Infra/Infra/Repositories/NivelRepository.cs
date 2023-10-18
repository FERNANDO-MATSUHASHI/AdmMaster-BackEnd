using Domain.Entites;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class NivelRepository : INivelRepository
    {
        private readonly SqlContext _context;

        public NivelRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Nivel> GetNivel()
        {
            return _context.Niveis.ToList();
        }

        public Nivel GetNivelById(int id)
        {
            return _context.Niveis.Find(id);
        }

        public void InsertNivel(Nivel nivel)
        {
            try
            {
                _context.Niveis.Add(nivel);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateNivel(Nivel nivel)
        {
            try
            {
                _context.Entry(nivel).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteNivel(Nivel nivel)
        {
            try
            {
                _context.Set<Nivel>().Remove(nivel);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}