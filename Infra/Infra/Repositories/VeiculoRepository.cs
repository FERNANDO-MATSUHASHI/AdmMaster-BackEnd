using Domain.Entites;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public void InsertVeiculo(Veiculo veiculo, int idTipoVeiculo)
        {
            try
            {
                _context.Veiculos.Add(veiculo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateVeiculo(Veiculo veiculo)
        {
            try
            {
                _context.Entry(veiculo).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteVeiculo(Veiculo veiculo)
        {
            try
            {
                _context.Set<Veiculo>().Remove(veiculo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}