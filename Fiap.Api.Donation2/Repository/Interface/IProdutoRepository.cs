using Fiap.Api.Donation2.Models;

namespace Fiap.Api.Donation2.Repository.Interface
{
    public interface IProdutoRepository
    {
        public IList<ProdutoModel> FindAll();

        public IList<ProdutoModel> FindAll(DateTime? dataReferencia, int tamanho);

        public int Count();

        public Task<ProdutoModel> FindById(int id);

        public Task<int> Insert(ProdutoModel model);

        public void Update(ProdutoModel model);

        public void Delete(int id);
    }
}
