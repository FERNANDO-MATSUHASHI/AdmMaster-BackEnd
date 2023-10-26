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

        public void InsertUser(Usuario user)
        {
            _cadUserService.InsertUser(user);
        }

        public void UpdateUser(Usuario user)
        {
            _cadUserService.UpdateUser(user);
        }

        public void DeleteUser(Usuario user)
        {
            _cadUserService.DeleteUser(user);
        }

        public List<Usuario> GetUser()
        {
            return _cadUserService.GetUser();
        }

        public Usuario GetUserById(int id)
        {
            return _cadUserService.GetUserById(id);
        }
    }
}