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
                    new Claim(ClaimTypes.Name, user.user_name.ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(0.02),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(chave), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = manipuladorToken.CreateToken(descritorToken);
            return manipuladorToken.WriteToken(token);
        }
    }
}