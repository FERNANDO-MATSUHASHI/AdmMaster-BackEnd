using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.Service.Services;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class UsuarioApplication : IUsuarioApplication
    {
        public readonly IUsuarioService _usuarioService;
        public readonly ICargoService _cargoService;

        public UsuarioApplication(IUsuarioService usuarioService, ICargoService cargoService)
        {
            _usuarioService = usuarioService;
            _cargoService = cargoService;
        }

        public List<Usuario> GetUsuarios()
        {
            return _usuarioService.GetUsuarios();
        }

        public Usuario GetUsuarioById(int id)
        {
            return _usuarioService.GetUsuarioById(id);
        }

        public void InsertUsuario(UsuarioViewModel usuarioViewModel)
        {
            var cargo = _cargoService.GetCargoById(usuarioViewModel.cargoId);
            if (cargo == null) throw new Exception("Cargo nao existe.");

            _usuarioService.InsertUsuario(usuarioViewModel, cargo);
        }

        public void UpdateUsuario(int id, UsuarioViewModel usuarioViewModel)
        {
            _usuarioService.UpdateUsuario(id, usuarioViewModel);
        }

        public void DeleteUsuario(int id)
        {
            _usuarioService.DeleteUsuario(id);
        }

        public List<ColaboradoresViewModel> GetColaboradores(int gerenteId)
        {
            return _usuarioService.GetColaboradores(gerenteId);
        }

        public void Login(LoginViewModel loginViewModel)
        {
            _usuarioService.Login(loginViewModel);
        }
    }
}
