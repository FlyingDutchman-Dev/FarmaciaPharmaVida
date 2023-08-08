using Modelo.ORM.BLL;
using Modelo.ORM.INFO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo.UI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja sair do Sistema?", "Atenção",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2)  == DialogResult.Yes)
            {
                e.Cancel = false;
            } else
            {
                e.Cancel=true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CategoriaInfo categ = new CategoriaInfo();
            CategoriaBLL categoriaBLL = new CategoriaBLL();

            categ.Descricao = txtDesc.Text;
            categ.IsAtivo = Convert.ToBoolean(chkAtivoCateg.Checked);

            categoriaBLL.Salvar(categ);
        }

        private void salvarCliente_Click(object sender, EventArgs e)
        {
            ClienteInfo clienteInfo = new ClienteInfo();
            ClienteBLL clienteBLL = new ClienteBLL();

            clienteInfo.NomeRazaoSocial = txtClienteNome.Text;
            clienteInfo.TipoPessoa = txtTipo.Text;
            clienteInfo.CPFCNPJ = txtCPFCNPJ.Text;
            clienteInfo.Endereco = txtEndereco.Text;
            clienteInfo.Complemento = txtComplemento.Text;
            clienteInfo.Bairro = txtBairro.Text;
            clienteInfo.CEP = txtCEP.Text;
            clienteInfo.Cidade = txtCidade.Text;
            clienteInfo.Estado = txtEstado.Text;
            clienteInfo.Telefone = txtTelefone.Text;
            clienteInfo.Celular = txtCelular.Text;
            clienteInfo.Email = txtEmail.Text;
            clienteInfo.IsAtivo = Convert.ToBoolean(chkAtivoCliente.Checked);

            clienteBLL.Salvar(clienteInfo);

        }

        private void salvarProduto_Click(object sender, EventArgs e)
        {
            ProdutoInfo produtoInfo = new ProdutoInfo();
            ProdutoBLL produtoBLL = new ProdutoBLL();

            produtoInfo.CategoriaID = int.Parse(txtCategoria.Text);
            produtoInfo.Descricao = txtDescricao.Text;
            produtoInfo.DescricaoReduzida = txtDescricaoRedu.Text;
            produtoInfo.Unidade = txtUnidade.Text;
            produtoInfo.ValorCusto = Convert.ToDecimal(txtValorCusto.Text);
            produtoInfo.PorcentagemLucro = Convert.ToDecimal(txtPorcentagem.Text);
            produtoInfo.ValorVenda = Convert.ToDecimal(txtValorVenda.Text);
            produtoInfo.CodigoBarra = txtCodigo.Text;
            produtoInfo.EstoqueAtual = int.Parse(txtEAtual.Text);
            produtoInfo.EstoqueMinimo= int.Parse(txtEMin.Text);
            produtoInfo.EstoqueMaximo = int.Parse(txtEMax.Text);
            produtoInfo.IsAtivo = Convert.ToBoolean(chkAtivoCliente.Checked);

            produtoBLL.Salvar(produtoInfo);
        }
    }
}
