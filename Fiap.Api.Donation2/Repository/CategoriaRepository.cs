using Fiap.Api.Donation2.Data;
using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.Donation2.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly DataContext _dataContext; 

        public CategoriaRepository(DataContext ctx)
        {
            _dataContext = ctx;
        }
        
        public async Task<IList<CategoriaModel>> FindAll()
        {
            return await _dataContext.Categorias
                               .AsNoTracking()
                               .ToListAsync(); 
    
        }

        public async Task<CategoriaModel> FindById(int id)
        {
            var categoria = await _dataContext.Categorias
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(c => c.CategoriaId == id);
            return categoria; 
        }

        public async void Delete(int id)
        {
            var categoriaModel = new CategoriaModel()
            {
                CategoriaId = id
            };

            _dataContext.Categorias.Remove(categoriaModel);
            _dataContext.SaveChanges();
        }

        public async Task<int> Insert(CategoriaModel categoriaModel)
        {
            _dataContext.Categorias.Add(categoriaModel);
            _dataContext.SaveChanges(); 
            return categoriaModel.CategoriaId; 
        }

        public async void Update(CategoriaModel categoriaModel)
        {
            _dataContext.Categorias.Update(categoriaModel);
            _dataContext.SaveChanges(); 
        }
    }
}
