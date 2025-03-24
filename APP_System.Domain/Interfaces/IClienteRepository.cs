using APP_Sytem.API.Models;

namespace APP_System.Domain.Interfaces
{
    public interface IClienteRepository
    {
        void Incluir(TbAtor _cliente);

        void Alterar(TbAtor _cliente);

        void Deletar(TbAtor _cliente);

        Task<TbAtor> SelecionarCliente(int _idCliente);

        Task<IEnumerable<TbAtor>> SelecionarTodos();

        Task<bool> SaveAllAsync();
    }
}