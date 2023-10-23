using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class TipoServicoRepository : ITipoServicoRepository
    {
        private readonly SqlContext _context;

        public TipoServicoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Tipo_Servico> GetTipoServicos()
        {
            return _context.Tipo_Servicos.ToList();
        }

        public Tipo_Servico GetTipoServicoById(int id)
        {
            return _context.Tipo_Servicos.Find(id);
        }

        public void InsertTipoServico(Tipo_Servico tipo_Servico)
        {

            _context.Tipo_Servicos.Add(tipo_Servico);
            _context.SaveChanges();
        }
        public void UpdateTipoServico(Tipo_Servico tipoServico)
        {
            _context.Tipo_Servicos.Update(tipoServico);
            _context.SaveChanges();
        }
        public void DeleteTipoServico(Tipo_Servico tipoServico)
        {
            _context.Tipo_Servicos.Remove(tipoServico);
            _context.SaveChanges();
        }
    }
}