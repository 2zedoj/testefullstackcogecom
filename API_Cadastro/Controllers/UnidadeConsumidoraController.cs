using API_Cadastro.Models.Entity;
using API_Cadastro.Views.Repository;
using API_Cadastro.Views.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API_Cadastro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadeConsumidoraController : Controller
    {
        private readonly IUnidadeConsumidoraRepository _unidadeConsumidoraRepository;
        public UnidadeConsumidoraController(IUnidadeConsumidoraRepository unidadeConsumidoraRepository)
        {
            _unidadeConsumidoraRepository = unidadeConsumidoraRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<UnidadeConsumidora>>> ReadUnidadeConsumidora()
        {
            return Ok(await _unidadeConsumidoraRepository.Read());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UnidadeConsumidora>> ReadUnidadeConsumidoraById(int id)
        {
            return Ok(await _unidadeConsumidoraRepository.ReadById(id));
        }

        [HttpPost]
        public async Task<ActionResult<UnidadeConsumidora>> CreateUnidadeConsumidora([FromBody] UnidadeConsumidora unidadeConsumidora)
        {
            return Ok(await _unidadeConsumidoraRepository.Create(unidadeConsumidora));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UnidadeConsumidora>> UpdateUnidadeConsumidora([FromBody] UnidadeConsumidora unidadeConsumidora, int id)
        {
            return Ok(await _unidadeConsumidoraRepository.Update(unidadeConsumidora, id));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UnidadeConsumidora>> DeleteUnidadeConsumidora(int id)
        {
            return Ok(await _unidadeConsumidoraRepository.Delete(id));
        }
    }
}
