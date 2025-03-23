using APP_System.Domain.Account;
using APP_Sytem.API.Interfaces;
using APP_Sytem.API.Models;
using APP_Sytem.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace APP_Sytem.API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class UsuarioController : Controller
    {
        public readonly IClienteRepository _iClienteRepository;

        public readonly IAuthenticate _authenticateService;

        [HttpGet]
        public async Task<ActionResult<UserToken>> Index()
        {
            TbAtor cliente = await _iClienteRepository.SelecionarCliente(48);

            var token = _authenticateService.GenerateToken(48, "israel094@hotmail.com");

            return new UserToken
            {
                Token = token
            };
        }

        // Construtor com Injeção de Dependência
        public UsuarioController(IClienteRepository iClienteRepository, IAuthenticate authenticateService)
        {
            _iClienteRepository = iClienteRepository ?? throw new ArgumentNullException(nameof(iClienteRepository));
            _authenticateService = authenticateService ?? throw new ArgumentNullException(nameof(authenticateService));
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserToken>> Selecionar(LoginModel loginModel)
        {
            TbAtor cliente = await _iClienteRepository.SelecionarCliente(48);

            var token = _authenticateService.GenerateToken(48, "israel094@hotmail.com");

            return new UserToken
            {
                Token = token
            };
        }
    }
}