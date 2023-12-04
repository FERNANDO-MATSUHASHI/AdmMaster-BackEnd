using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class ManutencaoRepository : IManutencaoRepository
    {
        private readonly SqlContext _context;

        public ManutencaoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Manutencao> GetManutencoes()
        {
            return _context.Manutencao.ToList();
        }

        public Manutencao GetManutencaoById(int id)
        {
            return _context.Manutencao.Find(id);
        }

        public void InsertManutencao(Manutencao manutencao)
        {
            _context.Manutencao.Add(manutencao);
            _context.SaveChanges();
        }
        public void UpdateManutencao(Manutencao manutencao)
        {
            _context.Manutencao.Update(manutencao);
            _context.SaveChanges();
        }
        public void DeleteManutencao(Manutencao manutencao)
        {
            _context.Manutencao.Remove(manutencao);
            _context.SaveChanges();
        }
        public List<Manutencao> GetManutencaoGerenteById(int gerenteId)
        {
            return _context.Manutencao.Where(x => x.gerenteId == gerenteId).ToList();
        }
    }
}