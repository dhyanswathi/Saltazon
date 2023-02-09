using Microsoft.IdentityModel.Tokens;
using Saltazon.Api.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Saltazon.Api.Services
{
    public interface ITokenManager
    {
        string Authenticate (string email, string password);
    }
    public class TokenManager : ITokenManager
    {
        private readonly string _tokenKey;

        public TokenManager(string tokenKey)
        {
            _tokenKey = tokenKey;
        }

        public string Authenticate(string email, string password)
        {

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_tokenKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, email)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
