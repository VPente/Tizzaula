using Microsoft.AspNetCore.Mvc;
using TizzaApi.Pizzarias.DTO;

namespace TizzaApi.Pizzarias
{
    [ApiController]
    [Route("[controller]")]
    public class PizzariaController: ControllerBase
    {
        private IServPizzaria _servPizzaria;
        public PizzariaController(IServPizzaria servPizzaria)
        {
            _servPizzaria = servPizzaria;
        }

        [HttpPost]
        public ActionResult Inserir(Pizzaria pizzaria)
        {
            try
            {
                _servPizzaria.InserirPizzaria(pizzaria);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("[controller]/{id}")]
        [HttpPut]
        public ActionResult Alterar(int id, [FromBody] AlterarPizzariaDTO alterarPizzariaDto)
        {
            try
            {
                _servPizzaria.AlterarPizzaria(id,alterarPizzariaDto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
