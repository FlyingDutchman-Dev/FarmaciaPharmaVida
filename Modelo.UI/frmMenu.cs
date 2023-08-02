using Modelo.ORM.BLL;
using Modelo.ORM.INFO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            categ.IsAtivo = Convert.ToBoolean(chkAtivo.Checked);

            categoriaBLL.Salvar(categ);
        }
    }
}
