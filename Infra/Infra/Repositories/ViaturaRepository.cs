using Domain.Entites;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class ViaturaRepository : IViaturaRepository
    {
        private readonly SqlContext _context;

        public ViaturaRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Viatura> GetViaturas()
        {
            //return _context.Viaturas.ToList();
            return (from viatura in _context.Viaturas
                    join tipoViatura in _context.Tipo_Viaturas on viatura.Tipo_ViaturaId equals tipoViatura.Id
                    select new Viatura
                    {
                        sigla = viatura.sigla,
                        obs_vtr = viatura.obs_vtr,
                        Tipo_Viatura = new Tipo_Viatura
                        {
                            marca = tipoViatura.marca,
                            modelo = tipoViatura.modelo,
                            placa = tipoViatura.placa,
                            descricao = tipoViatura.descricao
                        }
                    }).ToList();
        }

        public Viatura GetViaturaById(int id)
        {
            return _context.Viaturas.Include(x => x.Tipo_Viatura).FirstOrDefault(x => x.Id == id);
        }

        public void InsertViatura(Viatura viatura)
        {
            _context.Viaturas.Add(viatura);
            _context.SaveChanges();
        }
        public void UpdateViatura(Viatura viatura)
        {
            _context.Viaturas.Update(viatura);
            _context.SaveChanges();
        }
        public void DeleteViatura(Viatura viatura)
        {
            _context.Viaturas.Remove(viatura);
            _context.SaveChanges();
        }
    }
}