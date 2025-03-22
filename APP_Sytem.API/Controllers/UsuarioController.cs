using APP_System.Domain.Account;
using APP_Sytem.API.Interfaces;
using APP_Sytem.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_Sytem.API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class UsuarioController : Controller
    {
        public readonly IClienteRepository iClienteRepository;
        public readonly IAuthenticate _authenticateService;

        public async Task<ActionResult<UserToken>> Index()
        {
            TbAtor cliente = await iClienteRepository.SelecionarCliente(48);

            var token = _authenticateService.GenerateToken(48, "israel094@hotmail.com");

            return new UserToken
            {
                Token = token
            };
        }
    }
}