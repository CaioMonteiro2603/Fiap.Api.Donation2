using Fiap.Api.Donation2.Data;
using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.Donation2.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _dataContext; 

        public UsuarioRepository(DataContext ctx)
        {
            _dataContext = ctx;
        }
        public async void Delete(int id)
        {
            var usuarioModel = new UsuarioModel()
            {
                UsuarioId = id
            };

            _dataContext.Usuarios.Remove(usuarioModel); // o usuario model precisa cnter o id para ser removido, e seguindo 
            // a POO n pode-se colcoar o id, por isso passei o usuario model com valor de id; 
            _dataContext.SaveChanges(); 
        }

        public async Task<IList<UsuarioModel>> FindAll()
        {
            return await _dataContext.Usuarios
                                .AsNoTracking()
                                .ToListAsync(); 
        }

        public async Task<UsuarioModel> FindByEmailAndSenha(string email, string senha)
        {
            var usuario = await _dataContext.Usuarios
                                       .AsNoTracking()
                                       .FirstOrDefaultAsync(u => u.EmailUsuario == email &&
                                                               u.SenhaUsuario == senha);

            return usuario; 
        }

        public async Task<UsuarioModel> FindById(int id)
        {
            var usuario = await _dataContext.Usuarios
                                      .AsNoTracking()
                                      .FirstOrDefaultAsync(u => u.UsuarioId == id);
            return usuario; 
        }

        public async Task<int> Insert(UsuarioModel usuarioModel)
        {
            _dataContext.Usuarios.Add(usuarioModel);
            _dataContext.SaveChanges(); 
            return usuarioModel.UsuarioId; // precisa retornar um inteiro por isso o (usuarioID)
        }

        public async void Update(UsuarioModel usuarioModel)
        {
            _dataContext.Usuarios.Update(usuarioModel);
            _dataContext.SaveChanges(); 
        }
    }
}
