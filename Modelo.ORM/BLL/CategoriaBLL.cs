using Modelo.ORM.DAL;
using Modelo.ORM.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ORM.BLL
{
    public class CategoriaBLL
    {
        CategoriaDal dal = new CategoriaDal();

        public CategoriaInfo Salvar(CategoriaInfo obj)
        {
            return dal.Salvar(obj);
        }

        public CategoriaInfo Selecionar(int categID)
        {
            return dal.Selecionar(categID);
        }

        public bool Excluir(int categID)
        {
            return dal.Excluir(categID);
        }

        public List<CategoriaInfo> SelecionarTodos()
        {
            return dal.SelecionarTodos();
        }

        public List<CategoriaInfo> SelecionarFiltro(string DescricaoFiltro)
        {
            return dal.SelecionarFiltro(DescricaoFiltro);
        }
    }
}
