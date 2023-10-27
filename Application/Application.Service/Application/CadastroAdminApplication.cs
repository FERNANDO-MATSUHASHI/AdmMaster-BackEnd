using Application.Service.Interface;
using Domain.Service.Interfaces;
using Domain.Service.Services;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class CadastroAdminApplication : ICadastroAdminApplication
    {
        private readonly ICadastroAdminService _cadastroAdminService;

        public CadastroAdminApplication(ICadastroAdminService cadastroAdminService)
        {
            _cadastroAdminService = cadastroAdminService;
        }

        public void InsertNivel(NivelViewModel nivelViewModel)
        {
            _cadastroAdminService.InsertNivel(nivelViewModel);
        }

        public void InsertCargo(CargoViewModel cargoViewModel)
        {
            _cadastroAdminService.InsertCargo(cargoViewModel);
        }

        public void InsertUser(UsuarioViewModel usuarioViewModel)
        {
            _cadastroAdminService.InsertUser(usuarioViewModel);
        }
    }
}
