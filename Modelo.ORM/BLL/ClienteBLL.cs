using Modelo.ORM.DAL;
using Modelo.ORM.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ORM.BLL
{
    public class ClienteBLL
    {
        ClienteDal dal = new ClienteDal();

        public ClienteInfo Salvar(ClienteInfo obj)
        {
            return dal.Salvar(obj);
        }

        public ClienteInfo Selecionar(int clienteID)
        {
            return dal.Selecionar(clienteID);
        }

        public bool Excluir(int clienteID)
        {
            return dal.Excluir(clienteID);
        }

        public List<ClienteInfo> SelecionarTodos()
        {
            return dal.SelecionarTodos();
        }

        public List<ClienteInfo> SelecionarFiltro(string NomeFiltro)
        {
            return dal.SelecionarFiltro(NomeFiltro);
        }
    }
}
