using API_Cadastro.Models.Entity;
using API_Cadastro.Views.Repository;
using API_Cadastro.Views.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Cadastro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CooperadorController : ControllerBase
    {
        private readonly ICooperadoRepository _cooperadoRepository;
        public CooperadorController(ICooperadoRepository cooperadoRepository) {
            _cooperadoRepository = cooperadoRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Cooperado>>> ReadCooperado()
        {
            return Ok(await _cooperadoRepository.Read());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cooperado>> ReadCooperadoById(int id)
        {
            return Ok(await _cooperadoRepository.ReadById(id));
        }

        [HttpPost]
        public async Task<ActionResult<Cooperado>> CreateCooperado([FromBody] Cooperado cooperado)
        {
            return Ok(await _cooperadoRepository.Create(cooperado));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Cooperado>> UpdateCooperado([FromBody] Cooperado cooperado, int id)
        {
            return Ok(await _cooperadoRepository.Update(cooperado, id));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Cooperado>> DeleteCooperado(int id)
        {
            return Ok(await _cooperadoRepository.Delete(id));
        }
    }
}
