using Domain.Entites;
using Domain.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Application
{
    public class TokenApplication
    {
        readonly TokenService _tokenService;

        public TokenApplication(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        public void GerarToken(Usuario user)
        {
            var tokenGerado = _tokenService.GerarToken(user);
            if (tokenGerado != null)
            {
                //oculta a senha
                user.senha = "";


            }
        }
    }
}
