using APP_Sytem.API.Interfaces;
using APP_Sytem.API.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_Sytem.API.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly CApp_SystemApp_System_BancobancoSQLitedbContext context;

        public ClienteRepository(CApp_SystemApp_System_BancobancoSQLitedbContext _context)
        {
            context = _context;
        }

        public void Alterar(TbAtor _cliente)
        {
            context.Entry(_cliente).State = EntityState.Modified;
        }

        public void Incluir(TbAtor _cliente)
        {
            context.TbAtor.Add(_cliente);
        }

        public void Deletar(TbAtor _cliente)
        {
            context.TbAtor.Remove(_cliente);
        }

        public async Task<TbAtor> SelecionarCliente(int _idCliente)
        {
            TbAtor cliente = await context.TbAtor.FirstOrDefaultAsync(x => x.IdAtor.Equals(_idCliente));

            return cliente;
        }

        public async Task<IEnumerable<TbAtor>> SelecionarTodos()
        {
            var clientes = await context.TbAtor.Where(x => x.IdAtor <= 5).ToListAsync();

            return clientes;
        }

        public async Task<bool> SaveAllAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }
    }
}