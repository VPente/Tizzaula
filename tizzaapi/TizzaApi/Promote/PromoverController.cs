using Microsoft.AspNetCore.Mvc;
using TizzaApi.Pizzarias;
using TizzaApi.Pizzas;
using TizzaApi.Promote.DTO;

namespace TizzaApi.Promote
{
    [ApiController]
    [Route("[controller]")]
    public class PromoverController:ControllerBase
    {
        private IServPromover _servPromover;
        public PromoverController(IServPromover servPromover)
        {
            _servPromover = servPromover;
        }

        [HttpPost]
        public IActionResult Inserir(InserirPromoverDTO inserirPromoverDTO)
        {
            try
            {
                _servPromover.Inserir(inserirPromoverDTO);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                var Lista = _servPromover.Listar();

                return Ok(Lista);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("id")]
        public IActionResult BuscarPromover(int id)
        {
            try
            {
                var registro = _servPromover.BuscarPromover(id);

                return Ok(registro);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [Route("/[controller]/Efetivar/{id}")]
        [HttpPost]
        public IActionResult Efetivar(int id)
        {
            try
            {
                //_servPromover.Inserir(inserirPromoverDto);
                _servPromover.Efetivar(id);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }
    }
}
