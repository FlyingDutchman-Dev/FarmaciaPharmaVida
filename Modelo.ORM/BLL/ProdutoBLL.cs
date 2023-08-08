using Modelo.ORM.DAL;
using Modelo.ORM.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ORM.BLL
{
    public class ProdutoBLL
    {
        ProdutoDal dal = new ProdutoDal();

        public ProdutoInfo Salvar(ProdutoInfo obj)
        {
            return dal.Salvar(obj);
        }

        public ProdutoInfo Selecionar(int prodID)
        {
            return dal.Selecionar(prodID);
        }

        public bool Excluir(int prodID)
        {
            return dal.Excluir(prodID);
        }

        public List<ProdutoInfo> SelecionarTodos()
        {
            return dal.SelecionarTodos();
        }

        public List<ProdutoInfo> SelecionarFiltro(string DescricaoFiltro)
        {
            return dal.SelecionarFiltro(DescricaoFiltro);
        }
    }
}
