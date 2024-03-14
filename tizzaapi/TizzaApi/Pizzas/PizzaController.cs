using Microsoft.AspNetCore.Mvc;

namespace TizzaApi.Pizzas
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController: ControllerBase
    {
        private IServPizza _servPizza;
        public PizzaController(IServPizza pizza)
        {
            _servPizza = pizza;
        }

        [HttpPost]
        public ActionResult Inserir(Pizza pizza)
        {
            try
            {
                _servPizza.InserirPizza(pizza);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
