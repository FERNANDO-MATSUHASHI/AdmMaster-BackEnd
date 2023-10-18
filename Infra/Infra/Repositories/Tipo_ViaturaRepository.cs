using AdmMaster.Infra.MemoryDb.Interfaces;
using DDD.Domain.Entites;
using Infra;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmMaster.Infra.MemoryDb.Repositories
{
    public class Tipo_ViaturaRepository : ITipo_ViaturaRepository
    {
        private readonly SqlContext _context;
        public Tipo_ViaturaRepository(SqlContext context)
        {
            _context = context;
        }
        public List<Tipo_Viatura> GetTipoViatura()
        {
            return _context.Tipo_Viaturas.ToList();
        }

        public Tipo_Viatura GetTipoViaturaById(int id)
        {
            return _context.Tipo_Viaturas.Find(id);
        }

        public void InsertTipoViatura(Tipo_Viatura tipoViatura)
        {
            try
            {
                _context.Tipo_Viaturas.Add(tipoViatura);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                //log exception
                throw ex;
            }
        }

        public void UpdateTipoViatura(Tipo_Viatura tipoViatura)
        {
            try
            {
                _context.Entry(tipoViatura).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                //log exception
                throw ex;
            }
        }
        public void DeleteTipoViatura(Tipo_Viatura tipoViatura)
        {
            try
            {
                _context.Set<Tipo_Viatura>().Remove(tipoViatura);
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
