using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository;
using Fiap.Api.Donation2.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<CategoriaModel>>> GetAllAsync()
        {
            var categoria = await _categoriaRepository.FindAll();

            if(categoria != null && categoria.Count > 0)
            {
                return Ok(categoria);
            } else
            {
                return NoContent(); 
            }
        }
       [HttpGet("{id:int}")]
        public async Task<ActionResult<CategoriaModel>> GetIdAsync([FromRoute]int id) // esssa rota fala no postman que se usar um numero na hr de chamar, vai ser chamado esse método, 
            // se n for usado numero, sera chamado o metodo de cima
        {
            var categoria = await _categoriaRepository.FindById(id);

            if(categoria != null)
            {
                return Ok(categoria);
            } else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete([FromRoute]int id)
        {
            if(id == 0)
            {
                return BadRequest(); 
            }

             var categoria = _categoriaRepository.FindById(id); 
            if(categoria != null )
            {
                _categoriaRepository.Delete(id);
                return NoContent(); 
            }
            else
            {
                return NotFound(); 
            }
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaModel>> Post([FromBody]CategoriaModel categoriaModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            await _categoriaRepository.Insert(categoriaModel); 
            var url = Request.GetEncodedUrl().EndsWith("/") ?
                Request.GetEncodedUrl() : Request.GetEncodedUrl() + "/";

            url = url + categoriaModel.CategoriaId;

            return Created(url, categoriaModel);
        }

        [HttpPut("{id:int}")] //paramentro da categoria
        public async Task<ActionResult> Put([FromRoute]int id,[FromBody] CategoriaModel categoriaModel)
        {
            if((!ModelState.IsValid) || (id != categoriaModel.CategoriaId))
            {
                return BadRequest(); 
            } else
            {
                _categoriaRepository.Update(categoriaModel);
                return NoContent(); 
            }
        }
    }
}
