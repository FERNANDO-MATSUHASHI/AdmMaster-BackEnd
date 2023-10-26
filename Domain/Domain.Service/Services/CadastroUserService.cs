using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;
using Infra.Repositories;
using System.Text.RegularExpressions;

namespace Domain.Service.Services
{
    public class CadastroUserService : ICadastroUserService
    {
        private readonly ICadastroUserRepository _cadUserRepository;

        public CadastroUserService(ICadastroUserRepository cadUserRepository)
        {
            _cadUserRepository = cadUserRepository;
        }

        public List<Usuario> GetUser()
        {
            return _cadUserRepository.GetUser();
        }

        public Usuario GetUserById(int id)
        {
            return _cadUserRepository.GetUserById(id);
        }
        public void DeleteUser(Usuario usuario)
        {
            _cadUserRepository.DeleteUser(usuario);
        }

        public void InsertUser(Usuario usuario)
        {
            var userCpf = _cadUserRepository.GetUser().Where(x => x.cpf == usuario.cpf);
            if (userCpf.Count() > 0)
                throw new Exception("Cpf já cadastrado.");

            bool validaEmail = Regex.IsMatch(usuario.email, "/^[a - z0 - 9.] +@[a - z0 - 9] +\\.[a-z]+\\.([a - z] +)?$/i");
            if (!validaEmail)
                throw new Exception("Email invalido.");

            var userEmail = _cadUserRepository.GetUser().Where(x => x.email == usuario.email);
            if (userEmail.Count() > 0)
                throw new Exception("Email já cadastrado.");

            if (usuario.cpf.Length < 11 || usuario.cpf.Length > 11)
                throw new Exception("Cpf invalido.");

            _cadUserRepository.InsertUser(usuario);
        }

        public void UpdateUser(Usuario usuario)
        {
            var userCpf = _cadUserRepository.GetUser()
                            .Where(x => x.cpf == usuario.cpf);
            if (userCpf.Count() > 0)
                throw new Exception("Cpf já cadastrado.");

            var userEmail = _cadUserRepository.GetUser()
                            .Where(x => x.email == usuario.email);
            if (userEmail.Count() > 0)
                throw new Exception("Email já cadastrado.");

            if (usuario.cpf.Length < 11 || usuario.cpf.Length > 11)
                throw new Exception("Cpf invalido.");

            _cadUserRepository.UpdateUser(usuario);
        }
    }
}