using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace ValidateJWT
{
    public class JwtHandler: JwtSecurityTokenHandler
    {
        public JwtHandler()
        {
        }

        public object ValidateToken(string tokenTodecode, string publicKey)
        {
            try
            {
                var key = Encoding.ASCII.GetBytes(publicKey);
                var validations = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
                var claims= this.ValidateTokenPayload(new JwtSecurityToken(tokenTodecode), validations);
                if (claims != null)
                {
                    return claims;
                }
                else
                    return "";
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}