using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;
using Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
        public void InsertUser(Usuario usuario)
        {
            var userCpf = _cadUserRepository.GetUser().Where(x => x.cpf == usuario.cpf);
            if (userCpf.Count() > 0)
                throw new Exception("Cpf já cadastrado.");

            //bool validaEmail = Regex.IsMatch(usuario.email, "/^[a - z0 - 9.] +@[a - z0 - 9] +\\.[a-z]+\\.([a - z] +)?$/i");
            //if (!validaEmail)
            //    throw new Exception("Email invalido.");

            var userEmail = _cadUserRepository.GetUser().Where(x => x.email == usuario.email);
            if (userEmail.Count() > 0)
                throw new Exception("Email já cadastrado.");

            if (usuario.cpf.Length < 11 || usuario.cpf.Length > 11)
                throw new Exception("Cpf invalido.");

            _cadUserRepository.InsertUser(usuario);
        }

        public void UpdateUser(int id, Usuario usuario)
        {
            //var userCpf = _cadUserRepository.GetUser()
            //                .Where(x => x.cpf == usuario.cpf);
            //if (userCpf.Count() > 0)
            //    throw new Exception("Cpf já cadastrado.");

            //var userEmail = _cadUserRepository.GetUser()
            //                .Where(x => x.email == usuario.email);
            //if (userEmail.Count() > 0)
            //    throw new Exception("Email já cadastrado.");

            //if (usuario.cpf.Length < 11 || usuario.cpf.Length > 11)
            //    throw new Exception("Cpf invalido.");

            //_cadUserRepository.UpdateUser(usuario);

            var originalUsuario = _cadUserRepository.GetUserById(id);
            if (originalUsuario == null)
                throw new Exception("Usuario não existe.");

            originalUsuario.nome = usuario.nome;
            originalUsuario.cpf = usuario.cpf;
            originalUsuario.email = usuario.email;
            originalUsuario.data_nascimento = usuario.data_nascimento;
            originalUsuario.criado_em = usuario.criado_em;
            originalUsuario.cep = usuario.cep;
            originalUsuario.rua = usuario.rua;
            originalUsuario.numero = usuario.numero;
            originalUsuario.cidade = usuario.cidade;
            originalUsuario.estado = usuario.estado;
            originalUsuario.user_name = usuario.user_name;
            originalUsuario.senha = usuario.senha;
            originalUsuario.ativo = usuario.ativo;
            originalUsuario.comissao = usuario.comissao;
            originalUsuario.gerenteId = usuario.gerenteId;
            originalUsuario.cargoId = usuario.cargoId;

            _cadUserRepository.UpdateUser(originalUsuario);
        }
        public void DeleteUser(int id)
        {
            var originalUsuario = _cadUserRepository.GetUserById(id);
            if (originalUsuario == null)
                throw new Exception("Usuario não existe.");

            _cadUserRepository.DeleteUser(originalUsuario);
        }
    }
}
