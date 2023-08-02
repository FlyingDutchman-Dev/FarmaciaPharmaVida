using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ORM.INFO
{
    public class ProdutoInfo
    {
        public int ProdutoID { get; set; }
        public int CategoriaID { get; set; }
        public string Descricao { get; set; }
        public string DescricaoReduzida { get; set; }
        public string Unidade { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal PorcentagemLucro { get; set; }
        public decimal ValorVenda { get; set; }
        public string CodigoBarra { get; set; }
        public decimal EstoqueAtual { get; set; }
        public decimal EstoqueMinimo { get; set; }
        public decimal EstoqueMaximo { get; set; }
        public bool IsAtivo { get; set; }
        public string colunaExibicao { get { return Descricao; } }
    }
}
