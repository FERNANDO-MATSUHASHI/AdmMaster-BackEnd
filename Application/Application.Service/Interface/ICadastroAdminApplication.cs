using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface ICadastroAdminApplication
    {
        void InsertCargo(CargoViewModel cargoViewModel);
        void InsertNivel(NivelViewModel nivelViewModel);
        void InsertUser(UsuarioViewModel usuarioViewModel);
    }
}
