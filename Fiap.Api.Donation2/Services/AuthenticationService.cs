using Fiap.Api.Donation2.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Fiap.Api.Donation2.Services
{
    public class AuthenticationService
    {
        public static string GetToken(UsuarioModel usuarioModel) 
            //essa string vai gerar um token criado no settings
        {
            byte[] secret = Encoding.ASCII.GetBytes(Settings.SECRET_TOKEN);

            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler(); //vem da biblio criada

            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuarioModel.Nome),
                    new Claim(ClaimTypes.Email, usuarioModel.EmailUsuario),
                    new Claim(ClaimTypes.Role, usuarioModel.Regra)
                }), //composiçao de regras do claimsIdentity
                Expires = DateTime.UtcNow.AddMinutes(5), //data atual mais 5 minutos para expirar 
                Issuer = "fiap", 
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secret),
                SecurityAlgorithms.HmacSha256Signature),
            };

            SecurityToken securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor); 


            return jwtSecurityTokenHandler.WriteToken(securityToken); 
        }
    }
}
