using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class AbastecimentoRepository : IAbastecimentoRepository
    {
        private readonly SqlContext _context;

        public AbastecimentoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Abastecimento> GetAbastecimentos()
        {
            return _context.Abastecimento.ToList();
        }

        public Abastecimento GetAbastecimentoById(int id)
        {
            return _context.Abastecimento.Find(id);
        }

        public void InsertAbastecimento(Abastecimento abastecimento)
        {
            _context.Abastecimento.Add(abastecimento);
            _context.SaveChanges();
        }
        public void UpdateAbastecimento(Abastecimento abastecimento)
        {
            _context.Abastecimento.Update(abastecimento);
            _context.SaveChanges();
        }
        public void DeleteAbastecimento(Abastecimento abastecimento)
        {
            _context.Abastecimento.Remove(abastecimento);
            _context.SaveChanges();
        }
        public List<Abastecimento> GetAbastecimentoGerenteById(int gerenteId)
        {
            return _context.Abastecimento.Where(x => x.gerenteId == gerenteId).ToList();
        }
    }
}