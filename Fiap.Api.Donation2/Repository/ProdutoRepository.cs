using Fiap.Api.Donation2.Data;
using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.Donation2.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext _dataContext;

        public ProdutoRepository(DataContext ctx)
        {
            _dataContext = ctx;
        }

        public IList<ProdutoModel> FindAll()
        {
            return _dataContext.Produtos.ToList(); // o toList pega tudo
        }

        public IList<ProdutoModel> FindAll(DateTime? dataReferencia, int tamanho)
        {
            var produtos = _dataContext.Produtos
                                        .Where(p => p.DataCadastro > dataReferencia)
                                        .OrderBy(p => p. DataCadastro)
                                        ///.Skip(tamanho * pagina) // metodo perigoso de ser utilizado em paginacao
                                        .Take(tamanho)
                                        .AsNoTracking()
                                        .ToList();

            return produtos == null ? new List<ProdutoModel>() : produtos;
        }

        public int Count()
        {
            return  _dataContext.Produtos.Count(); 
        }

        public async Task<ProdutoModel> FindById(int id)
        {
            var produto = await _dataContext.Produtos
                                      .AsNoTracking()
                                      .FirstOrDefaultAsync(p => p.ProdutoId == id);
            return produto; 
        }

        public async Task<int> Insert(ProdutoModel model)
        {
            _dataContext.Produtos.Add(model);
            _dataContext.SaveChanges(); 
            return model.ProdutoId;
        }
        public async void Delete(int id)
        {
            var produtoModel = new ProdutoModel()
            {
                ProdutoId = id,
            };
            _dataContext.Produtos.Remove(produtoModel);
            _dataContext.SaveChanges();
        }
        public async void Update(ProdutoModel model)
        {
            _dataContext.Produtos.Update(model);
            _dataContext.SaveChanges(); 
        }

      
    }
}
