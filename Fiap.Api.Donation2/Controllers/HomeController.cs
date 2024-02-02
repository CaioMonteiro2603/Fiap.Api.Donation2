using Fiap.Api.Donation2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Fiap.Api.Donation2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private static readonly string endpoint = "https://5cb544bd07f233001424ceb8.mockapi.io/fiap/curso"; 

        [HttpGet]
        public async Task<string> GetAsync()
        {
            #region GET ALL - Obtendo uma lista 
            //HttpClient client = new HttpClient();

            //var resposta = await client.GetAsync(endpoint);

            //if(resposta != null && resposta.IsSuccessStatusCode)
            //{
            //    var conteudo = await resposta.Content.ReadAsStringAsync(); //texto json 

            //    var cursos = JsonConvert.DeserializeObject<List<CursoModel>>(conteudo); //transforma o json em objeto c#

            //    Console.Write("Lista obtida com sucesso"); 

            //} else
            //{
            //    Console.WriteLine("Erro - não foi possível obter os dados dos cursos."); 
            //}
            #endregion

            #region GET BY ID
            //HttpClient client = new HttpClient();

            //var idcurso = 6; 
            //var resposta = await client.GetAsync($"{endpoint}/{idcurso}");

            //if (resposta != null && resposta.IsSuccessStatusCode)
            //{
            //    var conteudo = await resposta.Content.ReadAsStringAsync(); //texto json 

            //    var curso = JsonConvert.DeserializeObject<CursoModel>(conteudo); //quando é id n precisa de uma lista 
            //}
            #endregion

            #region POST - Cadastrar curso 
            //var curso = new CursoModel()
            //{
            //    Id = "10",
            //    Nome = "TypeScript",
            //    Nivel = "Basico",
            //    Conclusao = false,
            //    Conteudo = "Texto sobre curso",
            //    PercentualConclusao = 10,
            //    Preco = "99.5"
            //}; 
            //HttpClient client = new HttpClient();
            //var conteudoJson = JsonConvert.SerializeObject(curso); // processo contrario (serializar)
            //var conteudoJsonString = new StringContent(conteudoJson,
            //    Encoding.UTF8, "application/Json"); // diz que o texto vai no formato de utf8 e ele é um JSON

            //var resposta = await client.PostAsync(endpoint, conteudoJsonString);

            //if (resposta != null && resposta.IsSuccessStatusCode)
            //{
            //    var respostaSucesso = await resposta.Content.ReadAsStringAsync();
            //    var cursoCadastrado = JsonConvert.DeserializeObject<CursoModel>(respostaSucesso);
            //}
            #endregion

            #region PUT - alterar produto
            //var curso = new CursoModel()
            //{
            //    Id = "9",
            //    Nome = "Node JS 2", // alterei o curso aqui e o id tambem
            //    Nivel = "Basico",
            //    Conclusao = false,
            //    Conteudo = "Texto sobre curso",
            //    PercentualConclusao = 10,
            //    Preco = "199.5"
            //};
            //HttpClient client = new HttpClient();
            //var conteudoJson = JsonConvert.SerializeObject(curso); // processo contrario (serializar)
            //var conteudoJsonString = new StringContent(conteudoJson,
            //    Encoding.UTF8, "application/Json"); // diz que o texto vai no formato de utf8 e ele é um JSON

            //var resposta = await client.PutAsync($"{endpoint}/{curso.Id}", conteudoJsonString);

            //if (resposta != null && resposta.IsSuccessStatusCode)
            //{
            //    var respostaSucesso = await resposta.Content.ReadAsStringAsync();
            //    var cursoCadastrado = JsonConvert.DeserializeObject<CursoModel>(respostaSucesso);
            //}
            #endregion

            #region Delete 
            //HttpClient client = new HttpClient();

            //var idcurso = 6;
            //var resposta = await client.DeleteAsync($"{endpoint}/{idcurso}");

            //if (resposta != null && resposta.IsSuccessStatusCode)
            //{
            //    var conteudo = await resposta.Content.ReadAsStringAsync();
            //    Console.WriteLine(conteudo); 
            //}
            #endregion

            //comando para altear uma API externa
            return "Get";
        }

        [HttpPost]
        public string Post()
        {
            return "Post";
        }

        [HttpPut]
        public string Put()
        {
            return "Put";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Delete"; 
        }
    }
}
