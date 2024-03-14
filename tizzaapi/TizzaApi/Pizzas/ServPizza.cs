namespace TizzaApi.Pizzas
{
    public interface IServPizza
    {
        void InserirPizza(Pizza pizza);
    }
    public class ServPizza: IServPizza
    {
        private DataContext _dataContext;

        public ServPizza(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void InserirPizza(Pizza pizza)
        {
            _dataContext.Add(pizza);
            _dataContext.SaveChanges();
        }
    }
}
