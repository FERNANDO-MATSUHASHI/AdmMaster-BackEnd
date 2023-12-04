using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class TipoCombustivelRepository : ITipoCombustivelRepository
    {
        private readonly SqlContext _context;

        public TipoCombustivelRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Tipo_Combustivel> GetTipoCombustiveis()
        {
            return _context.Tipo_Combustivel.ToList();
        }

        public Tipo_Combustivel GetTipoCombustivelById(int id)
        {
            return _context.Tipo_Combustivel.Find(id);
        }

        public void InsertTipoCombustivel(Tipo_Combustivel tipoCombustivel)
        {
            _context.Tipo_Combustivel.Add(tipoCombustivel);
            _context.SaveChanges();
        }

        public void UpdateTipoCombustivel(Tipo_Combustivel tipoCombustivel)
        {
            _context.Tipo_Combustivel.Update(tipoCombustivel);
            _context.SaveChanges();
        }
        public void DeleteTipoCombustivel(Tipo_Combustivel tipoCombustivel)
        {
            _context.Tipo_Combustivel.Remove(tipoCombustivel);
            _context.SaveChanges();
        }
    }
}