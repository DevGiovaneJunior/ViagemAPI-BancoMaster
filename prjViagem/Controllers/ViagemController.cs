using Microsoft.AspNetCore.Mvc;
using prjViagem.Domain.DTOs;
using prjViagem.Domain.Interfaces;

namespace Master.API.Viagem.Rest.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ViagemController : Controller
    {
        private readonly IApplicationServiceViagem _ApplicationServiceViagem;
        public ViagemController(IApplicationServiceViagem ApplicationServiceViagem)
        {
            _ApplicationServiceViagem = ApplicationServiceViagem;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_ApplicationServiceViagem.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_ApplicationServiceViagem.GetById(id));
        }
        [HttpGet("{Origem}/{Destino}")]
        public ActionResult<string> GetDestino(string Origem, string Destino)
        {
            return Ok(_ApplicationServiceViagem.GetDestino(Origem, Destino));
        }
        [HttpPost]
        public ActionResult Post([FromBody] ViagemRequestDTO ViagemDto)
        {
            try
            {
                if (ViagemDto == null)
                    return NotFound();

                _ApplicationServiceViagem.Add(ViagemDto);
                return Ok("Rota Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
        }
        [HttpPut]
        public ActionResult Put([FromBody] ViagemDTO ViagemDto)
        {
            try
            {
                if (ViagemDto == null)
                    return NotFound();

                _ApplicationServiceViagem.Update(ViagemDto);
                return Ok("Rota Atualizado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpDelete()]
        public ActionResult Delete([FromBody] ViagemDTO ViagemDto)
        {
            try
            {
                if (ViagemDto == null)
                    return NotFound();

                _ApplicationServiceViagem.Remove(ViagemDto);
                return Ok("Rota Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
