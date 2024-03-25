using API_Cadastro.Models.Entity;
using API_Cadastro.Views.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using ViaCep;

namespace API_Cadastro.Controllers
{
    public class EnderecoController : Controller
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoController(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Endereco>>> ReadEndereco()
        {
            return Ok(await _enderecoRepository.Read());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Endereco>> ReadEnderecoById(int id)
        {
            return Ok(await _enderecoRepository.ReadById(id));
        }

        [HttpPost]
        public async Task<ActionResult<Endereco>> CreateEndereco([FromBody] Endereco Endereco)
        {
            return Ok(await _enderecoRepository.Create(Endereco));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Endereco>> UpdateEndereco([FromBody] Endereco Endereco, int id)
        {
            return Ok(await _enderecoRepository.Update(Endereco, id));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Endereco>> DeleteEndereco(int id)
        {
            return Ok(await _enderecoRepository.Delete(id));
        }

        [HttpGet("/buscaCep/{cep}")]
        public async Task<ActionResult<String>> SearchCEP(string cep)
        {
            HttpClient cliente = new HttpClient();
            HttpResponseMessage resposta = await cliente.GetAsync(String.Format("https://viacep.com.br/ws/{0}/json/", cep));
            resposta.EnsureSuccessStatusCode();

            return await resposta.Content.ReadAsStringAsync();

        }
    }
}
