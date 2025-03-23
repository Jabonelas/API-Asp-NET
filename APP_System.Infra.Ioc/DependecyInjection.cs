using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP_System.Domain.Account;
using APP_System.Infra.Data.Context;
using APP_System.Infra.Data.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace APP_System.Infra.Ioc
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service,
            IConfiguration configuration)
        {
            service.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            service.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = configuration["jwt:issuer"],
                    ValidAudience = configuration["jwt:audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["jwt:secretKey"])),
                    ClockSkew = TimeSpan.Zero
                };
            });

            //service.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            //Repository
            //service.AddScoped<IClienteRepository, ClienteRepository>();
            //service.AddScoped<IUsuarioRepository, UsuarioRepository>();

            //Services
            //service.AddScoped<IClienteService, ClienteService>();
            //service.AddScoped<IUsuarioService, UsuarioService>();
            service.AddScoped<IAuthenticate, AuthenticateService>();

            return service;
        }
    }
}