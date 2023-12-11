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

        public List<Veiculo> GetVeiculos()
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
        public List<Veiculo> GetVeiculosByGerenteId(int gerenteId)
        {
            var query = (from i in _context.Veiculos.AsNoTracking()
                         where i.gerenteId == gerenteId
                         select new Veiculo
                         {
                             Id = i.Id,
                             valor_saida = i.valor_saida,
                             valor_km = i.valor_km,
                             adicional_noturno = i.adicional_noturno,
                             ris = i.ris,
                             patins = i.patins,
                             rodaExtra = i.rodaExtra,
                             hora_parada = i.hora_parada,
                             descricao = i.descricao,
                             Tipo_ServicoId = i.Tipo_ServicoId,
                             Tipo_VeiculoId = i.Tipo_VeiculoId,
                             viaturaId = i.viaturaId,
                             gerenteId = i.gerenteId
                         });
            return query.ToList();
        }
    }
}