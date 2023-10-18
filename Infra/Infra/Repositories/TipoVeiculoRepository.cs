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
            try
            {
                _context.Tipo_Veiculos.Add(tipoVeiculo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateTipoVeiculo(Tipo_Veiculo tipoVeiculo)
        {
            try
            {
                _context.Entry(tipoVeiculo).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteTipoVeiculo(Tipo_Veiculo tipoVeiculo)
        {
            try
            {
                _context.Set<Tipo_Veiculo>().Remove(tipoVeiculo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}