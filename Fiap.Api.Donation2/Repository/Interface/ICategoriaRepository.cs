using Fiap.Api.Donation2.Models;

namespace Fiap.Api.Donation2.Repository.Interface
{
    public interface ICategoriaRepository
    {
        public Task<IList<CategoriaModel>> FindAll();

        public Task<CategoriaModel> FindById(int id);

        public Task<int> Insert(CategoriaModel categoriaModel);

        public void Update(CategoriaModel categoriaModel);

        public void Delete(int id);
    }
}
