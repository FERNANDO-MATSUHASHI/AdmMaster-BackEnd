using DDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmMaster.Infra.MemoryDb.Interfaces
{
    public interface INivelRepository
    {
        public List<Nivel> GetNivel();
        public Nivel GetNivelById(int id);
        public void InsertNivel(Nivel nivel);
        public void UpdateNivel(Nivel nivel);
        public void DeleteNivel(Nivel nivel);
    }
}
