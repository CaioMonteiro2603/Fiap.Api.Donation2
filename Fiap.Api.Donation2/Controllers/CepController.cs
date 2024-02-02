using Fiap.Api.Donation2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        [HttpGet]
        public async Task<string> GetAsync()
        {
            var cep = "13665136";
            var url = $"https://viacep.com.br/ws/{cep}/json";
            HttpClient client = new HttpClient();

            var response = await client.GetAsync(url);

            if (response != null || response.IsSuccessStatusCode)
            {
                var conteudo = await response.Content.ReadAsStringAsync();

                CepModel? cepModel = Newtonsoft.Json.JsonConvert.DeserializeObject<CepModel>(conteudo);
            }
            return "Get";
        }
    }
}
