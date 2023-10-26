using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Interfaces
{
    public interface ICadastroUserService
    {
        List<Usuario> GetUser();
        Usuario GetUserById(int id);
        void InsertUser(Usuario usuario);
        void UpdateUser(int id, Usuario usuario);
        void DeleteUser(int id);
    }
}
