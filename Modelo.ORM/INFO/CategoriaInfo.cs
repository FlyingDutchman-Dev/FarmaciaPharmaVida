using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ORM.INFO
{
    public  class CategoriaInfo
    {
        public int CategoriaID { get; set; }
        public string Descricao { get; set; }
        public bool IsAtivo { get; set; }
        public string colunaExibicao { get { return Descricao; } }
    }
}
