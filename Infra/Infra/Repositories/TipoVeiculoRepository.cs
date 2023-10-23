using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class TipoVeiculoRepository : ITipoVeiculoRepository
    {
        private readonly SqlContext _context;

        public TipoVeiculoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Tipo_Veiculo> GetTipoVeiculo()
        {
            return _context.Tipo_Veiculos.ToList();
        }

        public Tipo_Veiculo GetTipoVeiculoById(int id)
        {
            return _context.Tipo_Veiculos.Find(id);
        }

        public void InsertTipoVeiculo(Tipo_Veiculo tipoVeiculo)
        {
            _context.Tipo_Veiculos.Add(tipoVeiculo);
            _context.SaveChanges();
        }

        public void UpdateTipoVeiculo(Tipo_Veiculo tipoVeiculo)
        {
            _context.Tipo_Veiculos.Update(tipoVeiculo);
            _context.SaveChanges();
        }
        public void DeleteTipoVeiculo(Tipo_Veiculo tipoVeiculo)
        {
            _context.Tipo_Veiculos.Remove(tipoVeiculo);
            _context.SaveChanges();
        }
    }
}