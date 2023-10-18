using Domain.Entites;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class TipoServicoRepository : ITipoServicoRepository
    {
        private readonly SqlContext _context;

        public TipoServicoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Tipo_Servico> GetTipoServico()
        {
            return _context.Tipo_Servicos.ToList();
        }

        public Tipo_Servico GetTipoServicoById(int id)
        {
            return _context.Tipo_Servicos.Find(id);
        }

        public void InsertTipoServico(Tipo_Servico tipo_Servico)
        {
            try
            {
                _context.Tipo_Servicos.Add(tipo_Servico);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateTipoServico(Tipo_Servico tipoServico)
        {
            try
            {
                _context.Entry(tipoServico).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteTipoServico(Tipo_Servico tipoServico)
        {
            try
            {
                _context.Set<Tipo_Servico>().Remove(tipoServico);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}