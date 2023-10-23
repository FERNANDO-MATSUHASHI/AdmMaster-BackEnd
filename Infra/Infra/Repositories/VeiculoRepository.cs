using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly SqlContext _context;

        public VeiculoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Veiculo> GetVeiculo()
        {
            return _context.Veiculos.ToList();
        }

        public Veiculo GetVeiculoById(int id)
        {
            return _context.Veiculos.Find(id);
        }

        public void InsertVeiculo(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
        }

        public void UpdateVeiculo(Veiculo veiculo)
        {
            _context.Veiculos.Update(veiculo);
            _context.SaveChanges();
        }
        public void DeleteVeiculo(Veiculo veiculo)
        {
            _context.Veiculos.Remove(veiculo);
            _context.SaveChanges();
        }
    }
}