using TizzaApi.Migrations;
using TizzaApi.Promote;
using TizzaApi.Promote.DTO;

namespace TizzaApi
{

public interface IServPromover
    { }
    public class ServPromover : IServPromover
    {
        private DataContext _dataContext;
        public ServPromover(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Inserir(InserirPromoverDTO inserirDTO)
        {
            var promover = new Promover();

            promover.Descricao = inserirDTO.Descricao;
            promover.CodigoPizzaria = inserirDTO.CodigoPizzaria;
            promover.DataVigencia = inserirDTO.DataVigencia;
            promover.Valor = inserirDTO.Valor;

            promover.Status = EnumStatusPromover.EmAberto;

            _dataContext.Add(promover);
            _dataContext.SaveChanges();

        }
    }
}
