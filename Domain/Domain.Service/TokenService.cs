using Domain.Entites;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Domain.Service
{
    public static class TokenService
    {
        public static string GerarToken(Usuario user)
        {
            var manipuladorToken = new JwtSecurityTokenHandler();
            var chave = Encoding.ASCII.GetBytes(Settings.Secret);
            var descritorToken = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    //você pode usar a reivindicação ClaimTypes.Name para armazenar o nome
                    //de usuário do usuário autenticado. Quando o token é verificado, você
                    //pode acessar essa reivindicação para obter o nome do usuário e usá - lo
                    //para personalizar a experiência do usuário ou tomar decisões com base no nome de usuário.
                    new Claim(ClaimTypes.Name, user.user_name.ToString()),
                    //você pode usar a reivindicação ClaimTypes.Role para atribuir uma ou várias funções a um usuário.
                    //As funções podem representar papéis específicos dentro do sistema, como "Administrador,"
                    //"Usuário" ou "Convidado".Quando um usuário faz login e é emitido um token JWT,
                    //a reivindicação ClaimTypes.Role pode ser usada para incluir informações sobre as funções do usuário.
                    new Claim(ClaimTypes.Role, user.Cargos.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(chave), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = manipuladorToken.CreateToken(descritorToken);
            return manipuladorToken.WriteToken(token);
        }
    }
}