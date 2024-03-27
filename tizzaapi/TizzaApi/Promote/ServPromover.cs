using TizzaApi.Migrations;
using TizzaApi.Pizzarias;
using TizzaApi.Promote;
using TizzaApi.Promote.DTO;

namespace TizzaApi
{

public interface IServPromover
    {
        void Inserir(InserirPromoverDTO inserirDTO);
        List<Promover> Listar();
        Promover BuscarPromover(int id);
        void Efetivar(int id);
    }
    public class ServPromover : IServPromover
    {
        private DataContext _dataContext;
        private IServPizzaria _servPizzaria; 
        public ServPromover(DataContext dataContext, IServPizzaria servPizzaria)
        {
            _dataContext = dataContext;
            _servPizzaria = servPizzaria;
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
        public void Efetivar(int id)
        {
            var promover = _dataContext.Promover.Where(p => p.Id == id).FirstOrDefault();

            promover.Status = EnumStatusPromover.Efetivado;
            _servPizzaria.RegistrarPatrocinio(promover.CodigoPizzaria, promover.Valor, promover.DataVigencia);
            _dataContext.SaveChanges();
        }
        public List<Promover> Listar()
        {
            var lista = _dataContext.Promover.ToList();

            return lista;
        }

        public Promover BuscarPromover(int id)
        {
            var promover = _dataContext.Promover.Where(p => p.Id == id).FirstOrDefault();
           
            return promover;
        }
    }
}
