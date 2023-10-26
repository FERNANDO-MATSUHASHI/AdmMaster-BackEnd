using Domain.Entites;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Domain.Service
{
    public static class TokenService
    {
        //public static string GerarToken(Usuario user)
        //{
        //    var manipuladorToke = new JwtSecurityTokenHandler();
        //    var chave = Encoding.ASCII.GetBytes(Settings.Secret);
        //    var descritorToken = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new Claim[]
        //        {
        //            new Claim(ClaimTypes.Name, user.Username.ToString()),
        //            new Claim(ClaimTypes.Role, user.Role.ToString())
        //        }),
        //        Expires = DateTime.UtcNow.AddHours(2),
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //    };
        //    var token = tokenHandler.CreateToken(tokenDescriptor);
        //    return tokenHandler.WriteToken(token);
        //}
    }
}