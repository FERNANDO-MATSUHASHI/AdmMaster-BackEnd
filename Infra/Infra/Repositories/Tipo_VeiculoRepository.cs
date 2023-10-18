using AdmMaster.Infra.MemoryDb.Interfaces;
using DDD.Domain.Entites;
using Infra;
using Microsoft.EntityFrameworkCore;

namespace AdmMaster.Infra.MemoryDb.Repositories
{
    public class Tipo_VeiculoRepository : ITipo_VeiculoRepository
    {
        private readonly SqlContext _context;
        public Tipo_VeiculoRepository(SqlContext context)
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
                //log exception
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
                //log exception
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
                //log exception
                throw ex;
            }
        }
    }
}
