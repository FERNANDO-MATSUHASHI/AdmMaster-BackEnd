using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;

namespace Domain.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        public readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public List<Usuario> GetUsuarios()
        {
            return _usuarioRepository.GetUsuarios();
        }

        public Usuario GetUsuarioById(int id)
        {
            return _usuarioRepository.GetUsuarioById(id);
        }

        public void InsertUsuario(UsuarioViewModel usuarioViewModel)
        {
            var usuario = new Usuario
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

        public void UpdateUsuario(int id, UsuarioViewModel usuarioViewModel)
        {
            var originalUsuario = _usuarioRepository.GetUsuarioById(id);
            if (originalUsuario == null)
                throw new Exception("Usuario nao existe.");

            originalUsuario.nome = usuarioViewModel.nome;
            originalUsuario.cpf = usuarioViewModel.cpf;
            originalUsuario.email = usuarioViewModel.email;
            originalUsuario.data_nascimento = usuarioViewModel.data_nascimento;
            originalUsuario.criado_em = DateTime.Now;
            originalUsuario.cep = usuarioViewModel.cep;
            originalUsuario.rua = usuarioViewModel.rua;
            originalUsuario.numero = usuarioViewModel.numero;
            originalUsuario.cidade = usuarioViewModel.cidade;
            originalUsuario.estado = usuarioViewModel.estado;
            originalUsuario.user_name = usuarioViewModel.user_name;
            originalUsuario.senha = usuarioViewModel.senha;
            originalUsuario.ativo = usuarioViewModel.ativo;
            originalUsuario.comissao = usuarioViewModel.comissao;
            originalUsuario.gerenteId = usuarioViewModel.gerenteId;
            originalUsuario.cargoId = usuarioViewModel.cargoId;

            _usuarioRepository.UpdateUsuario(originalUsuario);
        }

        public void DeleteUsuario(int id)
        {
            var originalUsuario = _usuarioRepository.GetUsuarioById(id);
            if (originalUsuario == null)
                throw new Exception("Usuario nao existe.");

            _usuarioRepository.DeleteUsuario(originalUsuario);
        }

        public List<ColaboradoresViewModel> GetColaboradores(int gerenteId)
        {
            var colaboradoresViewModel = _usuarioRepository.GetColaboradoresByGerenteId(gerenteId);

            return colaboradoresViewModel;
        }

        public string Login(LoginViewModel loginViewModel)
        {
            var usuario = _usuarioRepository.GetUsuarioByEmail(loginViewModel.email);
            if (usuario == null) throw new Exception("Usuario inexistente.");

            if (usuario.senha != loginViewModel.senha) throw new Exception("Senha errada.");

            var token = TokenService.GerarToken(usuario);

            return token;
        }
    }
}
