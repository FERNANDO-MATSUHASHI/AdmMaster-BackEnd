using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;
using Infra.Repositories;

namespace Domain.Service.Services
{
    public class CadastroAdminService : ICadastroAdminService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly INivelRepository _nivelRepository;
        private readonly ICargoRepository _cargoRepository;

        public CadastroAdminService(IUsuarioRepository usuarioRepository, INivelRepository nivelRepository, ICargoRepository cargoRepository)
        {
            _usuarioRepository = usuarioRepository;
            _nivelRepository = nivelRepository;
            _cargoRepository = cargoRepository;
        }

        public void InsertNivel(NivelViewModel nivelViewModel)
        {
            var nivel = new Nivel
            {
                nivel = nivelViewModel.nivel,
                descricao = nivelViewModel.descricao
            };

            _nivelRepository.InsertNivel(nivel);
        }

        public void InsertCargo(CargoViewModel cargoViewModel)
        {
            var nivel = _nivelRepository.GetNivelById(cargoViewModel.nivelId);
            if (nivel == null) throw new Exception("Nivel inexistente.");

            var cargo = new Cargo
            {
                descricao = cargoViewModel.descricao,
                Nivel = nivel
            };

            _cargoRepository.InsertCargo(cargo);
        }

        public void InsertUser(UsuarioViewModel usuarioViewModel)
        {
            var usuarios = _usuarioRepository.GetUsuarios();
            if (usuarios.Where(x => x.cpf == usuarioViewModel.cpf).Count() > 0)
                throw new Exception("Cpf já cadastrado.");

            if (usuarios.Where(x => x.email == usuarioViewModel.email).Count() > 0)
                throw new Exception("Email já cadastrado.");

            if (usuarioViewModel.cpf.Length < 11 || usuarioViewModel.cpf.Length > 11)
                throw new Exception("Cpf invalido.");

            var cargo = _cargoRepository.GetCargoById(usuarioViewModel.cargoId);
            if (cargo == null)
                throw new Exception("Cargo inexistente.");

            Usuario usuario = new Usuario
            {
                nome = usuarioViewModel.nome,
                cpf = usuarioViewModel.cpf,
                email = usuarioViewModel.email,
                data_nascimento = usuarioViewModel.data_nascimento,
                criado_em = DateTime.Now,
                cep = usuarioViewModel.cep,
                rua = usuarioViewModel.rua,
                numero = usuarioViewModel.numero,
                cidade = usuarioViewModel.cidade,
                estado = usuarioViewModel.estado,
                user_name = usuarioViewModel.user_name,
                senha = usuarioViewModel.senha,
                ativo = usuarioViewModel.ativo,
                comissao = usuarioViewModel.comissao,
                gerenteId = usuarioViewModel.gerenteId,
                cargoId = usuarioViewModel.cargoId
            };

            _usuarioRepository.InsertUsuario(usuario);
        }
    }
}
