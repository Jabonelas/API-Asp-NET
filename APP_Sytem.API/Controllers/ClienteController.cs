using APP_System.Infra.Ioc;
using APP_Sytem.API.DTOs;
using APP_Sytem.API.Interfaces;
using APP_Sytem.API.Models;
using APP_Sytem.API.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APP_Sytem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ClienteController : Controller
    {
        public readonly IClienteRepository iClienteRepository;
        public readonly IUsuarioRepository usuarioRepository;
        public readonly IMapper mapper;

        public ClienteController(IClienteRepository _iClienteRepository, IUsuarioRepository _usuarioRepository, IMapper _mapper)
        {
            iClienteRepository = _iClienteRepository;
            usuarioRepository = _usuarioRepository;
            mapper = _mapper;
        }

        [HttpGet("SelecionarTodos")]
        public async Task<ActionResult<IEnumerable<TbAtor>>> GetClientes()
        {
            var clientes = await iClienteRepository.SelecionarTodos();

            var listaClientesDTO = mapper.Map<List<ClienteDTO>>(clientes);

            return Ok(listaClientesDTO);
        }

        [HttpPost("CadastrarCliente")]
        public async Task<ActionResult> PostClientes(ClienteDTO _clienteDTO)
        {
            var cliente = mapper.Map<TbAtor>(_clienteDTO);

            iClienteRepository.Incluir(cliente);

            if (await iClienteRepository.SaveAllAsync())
            {
                return Ok("Cliente cadastrado com sucesso!");
            }

            return BadRequest("Ocorreu um erro o cliente não foi cadastrado!");
        }

        [HttpPut("AlterarCadastroCliente")]
        public async Task<ActionResult> AlterarCadastroCliente(ClienteDTO _clienteDTO)
        {
            if (_clienteDTO.IdAtor == null)
            {
                return BadRequest("Por favor infome o ID do cliente para ser alterado!");
            }

            TbAtor clienteSelecionado = await iClienteRepository.SelecionarCliente(_clienteDTO.IdAtor);

            if (clienteSelecionado == null)
            {
                return NotFound("O cliente nao foi encontrado!");
            }

            var cliente = mapper.Map<TbAtor>(_clienteDTO);

            iClienteRepository.Alterar(cliente);

            if (await iClienteRepository.SaveAllAsync())
            {
                return Ok("Cliente alterado com sucesso!");
            }

            return BadRequest("Ocorreu um erro o cliente não foi alterado!");
        }

        [HttpDelete("{_idCliente}")]
        public async Task<ActionResult> DeletarCadastroCliente(int _idCliente)
        {
            var userID = User.GetId();

            bool usuarioADM = usuarioRepository.IsUsuarioADM(userID);

            if (usuarioADM == false)
            {
                return Ok("O cliente não possui autorização para esta ação!");
            }

            TbAtor clienteSelecionado = await iClienteRepository.SelecionarCliente(_idCliente);

            if (clienteSelecionado == null)
            {
                return NotFound("Cliente nao encontrado!");
            }

            iClienteRepository.Deletar(clienteSelecionado);

            if (await iClienteRepository.SaveAllAsync())
            {
                return Ok("Cliente deletado com sucesso!");
            }

            return BadRequest("Ocorreu um erro o cliente não foi deletado!");
        }

        [HttpGet("{_idCliente}")]
        public async Task<ActionResult> SelecionarClienteId(int _idCliente)
        {
            TbAtor cliente = await iClienteRepository.SelecionarCliente(_idCliente);

            if (cliente == null)
            {
                return NotFound("O cliente nao foi encontrado!");
            }

            var clienteDTO = mapper.Map<ClienteDTO>(cliente);

            return Ok(clienteDTO);
        }
    }
}