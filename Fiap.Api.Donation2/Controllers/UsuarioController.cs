using AutoMapper;
using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository.Interface;
using Fiap.Api.Donation2.Services;
using Fiap.Api.Donation2.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using AuthenticationService = Fiap.Api.Donation2.Services.AuthenticationService;

namespace Fiap.Api.Donation2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // autorizacao do controler geral
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        private readonly IMapper _mapper; 

        public UsuarioController(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository; 
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "admin, operador, revisor")]
        public async Task<ActionResult<IList<UsuarioResponseVM>>> GetAllAsync()
        {
            var usuarios = await _usuarioRepository.FindAll();

            if(usuarios != null && usuarios.Count > 0)
            {
                var response = _mapper.Map<List<UsuarioResponseVM>>(usuarios);
                return Ok(response);
            } else
            {
                return NoContent(); 
            }
        }

        [HttpGet("{id:int}")]
        [Authorize(Roles = "admin, operador, revisor")]
        public async Task<ActionResult<UsuarioModel>> GetAsync(int id)
        {
           var usuario = await _usuarioRepository.FindById(id); 

            if(usuario != null)
            {
                return Ok(usuario);
            } else
            {
                return NotFound(); 
            }
            
        }

        [HttpDelete("{id:int}")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Delete([FromRoute]int id)
        {
            if(id == 0)
            {
                return BadRequest(); // logica: procurei um id pra apagar, mas esse id n existe
            }

            var usuario = _usuarioRepository.FindById(id);

            if(usuario != null)
            {
                _usuarioRepository.Delete(id); //logica: achei oq tava procurando? apaga e retorna sem conteudo
                return NoContent();
            } else
            {
                return NotFound(); // nao achei
            }
            
             
        }

        [HttpPost]
        [Authorize(Roles = "admin, operador")]
        public async Task<ActionResult<UsuarioResponseVM>> Post([FromBody]UsuarioRequestVM usuarioRequestVM)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(); 
            }

            var userModel = _mapper.Map<UsuarioModel>(usuarioRequestVM);
            await _usuarioRepository.Insert(userModel);

            var url = Request.GetEncodedUrl().EndsWith("/") ? //capta a url do postamn
                Request.GetEncodedUrl() :
                Request.GetEncodedUrl() + "/";

            url = url + userModel.UsuarioId;

            var usuarioResponseVM = _mapper.Map<UsuarioResponseVM>(userModel); 

            return Created(url, usuarioResponseVM); 
            
        }

        [HttpPut("{id:int}")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Put([FromRoute] int id, [FromBody] UsuarioRequestVM usuarioRequestVM)
        {
            if((!ModelState.IsValid) || (id != usuarioRequestVM.UsuarioId))
            {
                return BadRequest(); 
            }else
            {
                var userRequest = _mapper.Map<UsuarioModel>(usuarioRequestVM);
                _usuarioRepository.Update(userRequest);
                return NoContent(); // n preciso retornar nada, so fiz um update
            }
        }

        [HttpPost]
        [Route("Login")] // para difrenciar os httppost
        [AllowAnonymous]
        public async Task<ActionResult<LoginResponseVM>> Login([FromBody] LoginRequestVM loginRequestVM)
        {

            var usuario = await _usuarioRepository.FindByEmailAndSenha(
            loginRequestVM.EmailUsuario,
            loginRequestVM.Senha);

            if (usuario != null)
            {
                //gerar token de acesso:
                var token = AuthenticationService.GetToken(usuario); //usuario do banco de dados

                var loginResponseVM = _mapper.Map<LoginResponseVM>(usuario);
                loginResponseVM.Token = token; // o token n é um paramentro do usuario model

                return Ok(loginResponseVM);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
