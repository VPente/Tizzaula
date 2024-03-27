using TizzaApi.Pizzarias.DTO;

namespace TizzaApi.Pizzarias
{
    public interface IServPizzaria
    {
        void InserirPizzaria(Pizzaria pizzaria);
        void AlterarPizzaria(int id, AlterarPizzariaDTO alterarPizzariaDto);
        public void RegistrarPatrocinio(int codigoPizzaria, decimal valorPromover, DateTime dataVigenciaPromover);
    }

    public class ServPizzaria: IServPizzaria
    {
        private DataContext _dataContext;

        public ServPizzaria(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void InserirPizzaria(Pizzaria pizzaria)
        {
            _dataContext.Add(pizzaria);
            _dataContext.SaveChanges();
        }

        public void AlterarPizzaria(int id,AlterarPizzariaDTO alterarPizzariaDto)
        {
            var pizzaria = _dataContext.Pizzaria.Where(p => p.Id == id).FirstOrDefault();

            pizzaria.Nome = alterarPizzariaDto.Nome;
            pizzaria.Endereco = alterarPizzariaDto.Endereco;
            pizzaria.Telefone = alterarPizzariaDto.Telefone;
            pizzaria.Responsavel = alterarPizzariaDto.Responsavel;

            _dataContext.SaveChanges();
        }

        public void RegistrarPatrocinio(int codigoPizzaria, decimal valorPromover, DateTime dataVigenciaPromover)
        {
            var pizzaria = _dataContext.Pizzaria.Where(p => p.Id == codigoPizzaria).FirstOrDefault();

            pizzaria.ValorPromover = valorPromover;
            pizzaria.DataVigenciaPromover = dataVigenciaPromover;
        }
    }
}
