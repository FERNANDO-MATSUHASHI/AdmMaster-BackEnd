using AdmMaster.Infra.MemoryDb.Interfaces;
using DDD.Domain.Entites;
using Infra;
using Microsoft.EntityFrameworkCore;

namespace AdmMaster.Infra.MemoryDb.Repositories
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
                //log exception
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
                //log exception
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
                //log exception
                throw ex;
            }
        }
    }
}
