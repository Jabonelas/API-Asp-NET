using APP_System.Domain.Interfaces;
using APP_System.Infra.Data.Context;
using APP_Sytem.API.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_Sytem.API.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CApp_SystemApp_System_BancobancoSQLitedbContext context;

        public UsuarioRepository(CApp_SystemApp_System_BancobancoSQLitedbContext _context)
        {
            context = _context;
        }

        public bool IsUsuarioADM(int _id)
        {
            TbAtor usuario = context.TbAtor.FirstOrDefault(x => x.IdAtor == _id);

            bool isUsuarioADM = usuario.AtAtorTipo == 102 ? true : false;

            return isUsuarioADM;
        }
    }
}