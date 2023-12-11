using Domain.Entites;
using Domain.ViewModel;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class TipoViaturaRepository : ITipoViaturaRepository
    {
        private readonly SqlContext _context;

        public TipoViaturaRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Tipo_Viatura> GetTipoViaturas()
        {
            return _context.Tipo_Viaturas.ToList();
        }

        public Tipo_Viatura GetTipoViaturaById(int id)
        {
            return _context.Tipo_Viaturas.Find(id);
        }

        public void InsertTipoViatura(Tipo_Viatura tipoViatura)
        {
            _context.Tipo_Viaturas.Add(tipoViatura);
            _context.SaveChanges();
        }

        public void UpdateTipoViatura(Tipo_Viatura tipoViatura)
        {
            _context.Tipo_Viaturas.Update(tipoViatura);
            _context.SaveChanges();
        }
        public void DeleteTipoViatura(Tipo_Viatura tipoViatura)
        {
            _context.Tipo_Viaturas.Remove(tipoViatura);
            _context.SaveChanges();
        }
        public List<Tipo_Viatura> GetTipoViaturasByGerenteId(int gerenteId)
        {
            var query = (from i in _context.Tipo_Viaturas.AsNoTracking()
                         where i.gerenteId == gerenteId
                         select new Tipo_Viatura
                         {
                             Id = i.Id,
                             marca = i.marca,
                             modelo = i.modelo,
                             placa = i.placa,
                             ano = i.ano,
                             ano_modelo = i.ano_modelo,
                             descricao = i.descricao,
                             gerenteId = i.gerenteId
                         });
            return query.ToList();
        }
    }
}