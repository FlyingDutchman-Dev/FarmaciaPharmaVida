using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ORM.INFO
{
    public class ClienteInfo
    {
        public int ClienteID { get; set; }
        public string NomeRazaoSocial { get; set; }
        public string TipoPessoa { get; set; }
        public string CPFCNPJ { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public bool IsAtivo { get; set; }
        public string colunaExibicao { get { return NomeRazaoSocial; } }
    }
}
