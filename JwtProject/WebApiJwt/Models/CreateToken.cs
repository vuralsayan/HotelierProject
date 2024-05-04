using Microsoft.IdentityModel.Tokens;
using System.Diagnostics.SymbolStore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApiJwt.Models
{
    public class CreateToken
    {
        public string TokenCreate()
        {
            var bytes = Encoding.UTF8.GetBytes("bu benim kimlik doğrulama için kullandığım gizli anahtarım");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(
                               issuer: "http://localhost",
                                              audience: "http://localhost",
                                                     notBefore: DateTime.Now,
                                                             expires: DateTime.Now.AddSeconds(20),
                                                                            signingCredentials: signingCredentials
                                                                                       );
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }

        public string TokenCreateAdmin()
        {
            var bytes = Encoding.UTF8.GetBytes("bu benim kimlik doğrulama için kullandığım gizli anahtarım");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, "Admin"),
                new Claim(ClaimTypes.Role, "Visitor")
            };
            JwtSecurityToken token = new JwtSecurityToken(
                               issuer: "http://localhost",
                                              audience: "http://localhost",
                                                             notBefore: DateTime.Now,
                                                                            expires: DateTime.Now.AddSeconds(30),
                                                                                           signingCredentials: signingCredentials,
                                                                                                          claims: claims
                                                                                                      );
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }
    }
}
