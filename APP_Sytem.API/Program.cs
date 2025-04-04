using System.Security.Cryptography.X509Certificates;
using APP_System.Domain.Account;
using APP_System.Domain.Interfaces;
using APP_System.Infra.Data.Identity;
using APP_System.Infra.Ioc;
using APP_Sytem.API.Mappings;
using APP_Sytem.API.Models;
using APP_Sytem.API.Repository;
using Microsoft.EntityFrameworkCore;

namespace APP_Sytem.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<CApp_SystemApp_System_BancobancoSQLitedbContext>(options =>
            {
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddInfrastructureSwagger();
            //builder.Services.AddSwaggerGen();
            builder.Services.AddInfrastructure(builder.Configuration);

            builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
            builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            builder.Services.AddScoped<IAuthenticate, AuthenticateService>();
            builder.Services.AddAutoMapper(typeof(EntitiesToDTOMappingProfile));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            //app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}