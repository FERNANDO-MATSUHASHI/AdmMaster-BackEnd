using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class UsuarioApplication : IUsuarioApplication
    {
        public readonly IUsuarioService _usuarioService;

        public UsuarioApplication(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public List<Usuario> GetUsuarios()
        {
            return _usuarioService.GetUsuarios();
        }

        public Usuario GetUsuarioById(int id)
        {
            return _usuarioService.GetUsuarioById(id);
        }

        public void InsertUsuario(UsuarioViewModel UsuarioViewModel)
        {
            _usuarioService.InsertUsuario(UsuarioViewModel);
        }

        public void UpdateUsuario(int id, UsuarioViewModel UsuarioViewModel)
        {
            _usuarioService.UpdateUsuario(id, UsuarioViewModel);
        }

        public void DeleteUsuario(int id)
        {
            _usuarioService.DeleteUsuario(id);
        }
    }
}
