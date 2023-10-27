using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface ICadastroAdminService
    {
        void InsertCargo(CargoViewModel cargoViewModel);
        void InsertNivel(NivelViewModel nivelViewModel);
        void InsertUser(UsuarioViewModel usuarioViewModel);
    }
}
