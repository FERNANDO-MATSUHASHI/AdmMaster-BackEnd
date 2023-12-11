using Domain.Entites;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class TipoVeiculoRepository : ITipoVeiculoRepository
    {
        private readonly SqlContext _context;

        public TipoVeiculoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Tipo_Veiculo> GetTipoVeiculos()
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
        public List<Tipo_Veiculo> GetTipoVeiculosByGerenteId(int gerenteId)
        {
            var query = (from i in _context.Tipo_Veiculos.AsNoTracking()
                         where i.gerenteId == gerenteId
                         select new Tipo_Veiculo
                         {
                             Id = i.Id,
                             modelo = i.modelo,
                             descricao = i.descricao,
                             gerenteId = i.gerenteId
                         });
            return query.ToList();
        }
    }
}