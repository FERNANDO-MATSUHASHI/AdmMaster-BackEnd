using DDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmMaster.Infra.MemoryDb.Interfaces
{
    public interface IUsuarioRepository
    {
        public List<Usuario> GetUsuario();
        public Usuario GetUsuarioById(int id);
        public void InsertUsuario(Usuario usuario, int idCargo);
        public void UpdateUsuario(Usuario usuario);
        public void DeleteUsuario(Usuario usuario);
    }
}
