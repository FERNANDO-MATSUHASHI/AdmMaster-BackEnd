using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class CadastroUserApplication : ICadastroUserApplication
    {
        private readonly ICadastroUserService _cadUserService;

        public CadastroUserApplication(ICadastroUserService cadUserService)
        {
            _cadUserService = cadUserService;
        }
        public List<Usuario> GetUser()
        {
            return _cadUserService.GetUser();
        }
        public Usuario GetUserById(int id)
        {
            return _cadUserService.GetUserById(id);
        }
        public void InsertUser(Usuario usuario)
        {
            _cadUserService.InsertUser(usuario);
        }

        public void UpdateUser(int id, Usuario usuario)
        {
            _cadUserService.UpdateUser(id, usuario);
        }

        public void DeleteUser(int id)
        {
            _cadUserService.DeleteUser(id);
        }
    }
}
