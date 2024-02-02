using Fiap.Api.Donation2.Data;
using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation2.Controllers
{
    [ApiVersion("3.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository; 
        }

        [HttpGet]
        public ActionResult<IList<dynamic>> GetProdutos( //metodo de paginacao usado em bancos de dados grandes 
            [FromQuery] string dataReferencia,
            [FromQuery]int tamanho = 5) // se o tamanho n for informado = 5
        {
            var data = (string.IsNullOrEmpty(dataReferencia)) ? DateTime.UtcNow.AddYears(-200)
                : DateTime.ParseExact(dataReferencia, "yyyy-MM-ddTHH:mm:ss.ff", null, System.Globalization.DateTimeStyles.RoundtripKind);
            //transformei uma data em string
            var produto = _produtoRepository.FindAll(data, tamanho);

            var novaDataReferencia = produto.LastOrDefault().DataCadastro.ToString("yyyy-MM-ddTHH:mm:ss.ffffffF");  

            var linkProxima = $"/api/produto?datReferencia={novaDataReferencia}&tamanho={tamanho}"; 
            

            if(produto == null || produto.Count == 0)
            {
                return NoContent();
            }

            var retorno = new
            {
                produto, 
                linkProxima   
            };
            return Ok(retorno);
        }

        //metodo quando o skip é utilizado

        //[HttpGet]
        //public ActionResult<IList<dynamic>> GetProdutos(
        //    [FromQuery] int pagina = 0, // se a pagina n for informado = 0
        //    [FromQuery] int tamanho = 5) // se o tamanho n for informado = 5
        //{

        //    var totalGeral = _produtoRepository.Count();
        //    var totalPages = Convert.ToInt16(Math.Ceiling((double)totalGeral / tamanho));
        //    var linkProxima = (pagina < totalPages - 1) ? $"/api/produto?pagina={pagina + 1}&tamanho={tamanho}" : ""; // o -1 é pq as pag começam do 0 
        //    var linkAnterior = (pagina > 0) ? $"/api/produto?pagina={pagina - 1}&tamanho={tamanho}" : "";

        //    if (pagina > totalPages)
        //    {
        //        return NotFound();
        //    }
        //    var produto = _produtoRepository.FindAll(pagina, tamanho);

        //    if (produto == null)
        //    {
        //        return NoContent();
        //    }

        //    var retorno = new
        //    {
        //        produto,
        //        totalPages,
        //        totalGeral,
        //        linkProxima,
        //        linkAnterior,
        //        pagina = pagina,
        //        tamanho = tamanho
        //    };
        //    return Ok(retorno);
        //}

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProdutoModel>> GetIdAsync([FromRoute] int id)
        {

            
            var produto = await _produtoRepository.FindById(id); 
            if(produto != null)
            {
                return Ok(produto);
            } else
            {
                return NotFound(); 
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            if(id == 0)
            {
                return BadRequest(); 
            }
            var categoria = await _produtoRepository.FindById(id);
            if(categoria  != null)
            {
                _produtoRepository.Delete(id); 
                return NoContent();
            } else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoModel>> Post([FromBody] ProdutoModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _produtoRepository.Insert(model);
            var url = Request.GetEncodedUrl().EndsWith("/") ?
                Request.GetEncodedUrl() : Request.GetEncodedUrl() + "/";

            url = url + model.ProdutoId;

            return Created(url, model); 
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put([FromRoute] int id, [FromBody] ProdutoModel model)
        {
            if((!ModelState.IsValid) || (id != model.ProdutoId))
            {
                return BadRequest(); 
            } else
            {
                _produtoRepository.Update(model);
                return NoContent();
            }
        }
    }
}
