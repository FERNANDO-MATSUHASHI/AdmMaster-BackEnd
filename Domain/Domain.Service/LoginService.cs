using Infra.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System;

public class LoginService
{
    readonly IUsuarioRepository _usuariosRepository;
    public LoginService(IUsuarioRepository usuarioRepository)
    {
        _usuariosRepository = usuarioRepository;
    }

    // ao digitar o username e o password devemos verificar dentro da tabela de usuario 
    // se ele está cadastrado no banco de dados.

    public bool VerificarLogin()
}
