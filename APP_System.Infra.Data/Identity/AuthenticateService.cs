using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using APP_System.Domain.Account;
using APP_System.Infra.Data.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace APP_System.Infra.Data.Identity
{
    public class AuthenticateService : IAuthenticate
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        // Construtor para injetar dependências
        public AuthenticateService(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public string GenerateToken(int _id, string _email)
        {
            var claims = new[]
            {
                new Claim("id", _id.ToString()),
                new Claim("email", _email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var privateKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwt:secretKey"]));

            var credentials = new SigningCredentials(privateKey, SecurityAlgorithms.HmacSha256);

            var expiration = DateTime.UtcNow.AddMinutes(10);

            JwtSecurityToken token = new JwtSecurityToken(

                issuer: _configuration["jwt:issuer"],
                audience: _configuration["jwt:audience"],
                claims: claims,
                expires: expiration,
                signingCredentials: credentials

            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}